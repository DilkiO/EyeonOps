using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeonOps.controls;
using EyeonOps.data;
using EyeonOps.models;

namespace EyeonOps.form
{
    public partial class MainLayoutForm : Form
    {
        private alertSideBarControl _alertSideBar;
        private bool isAlertSidebarOpen = false;
        public MainLayoutForm()
        {
            InitializeComponent();
        }

        private void MainLayoutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Load Forms in Main Layout Method
        private void LoadFormInPanel(Form form)
        {
            foreach (Control control in FormLoadMainLayout.Controls)
            {
                if (control != null) control.Dispose();
            }
            FormLoadMainLayout.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            FormLoadMainLayout.Controls.Add(form);
            form.Show();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new DashboardForm());
        }

        private void WIPTrackerBtn_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new WipTrackerForm());
        }

        private void AssignmentBtn_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new AssignmentReassignmentForm());
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new SettingsForm());
        }

        private void MainLayoutForm_Load(object sender, EventArgs e)
        {
            LoadFormInPanel(new DashboardForm());
            updateoperatorstatustimer.Start();

            _alertSideBar = new alertSideBarControl();
            _alertSideBar.Visible = false;
            _alertSideBar.Dock = DockStyle.Right;

            this.Controls.Add(_alertSideBar);
            _alertSideBar.BringToFront();
        }

        private void operatorsBtn_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new OperatorsForm());
        }

        private void updateoperatorstatustimer_Tick(object sender, EventArgs e)
        {
            //Debug.WriteLine("Testing");
            List<Style> Stylelist = new StyleAccess().GetAllStyleDataWithStatus();
            foreach (Style style in Stylelist)
            {
                OperatorAccess operatorAccess = new OperatorAccess();
                if (style.OperatorStatus=="Idle")
                    continue;
                switch (style.FinalStatus)
                {
                    case "PENDING":
                        operatorAccess.UpdateOperatorStatusByStatusName(style.OperatorID, "Idle");
                        break;
                    case "IN PROCESS":
                        operatorAccess.UpdateOperatorStatusByStatusName(style.OperatorID, "Idle");
                        break;
                    case "WAITING":
                        //Debug.WriteLine((DateTime.Now-style.StatusUpdateTrackingDateTime).TotalMinutes>30);
                        if ((DateTime.Now - style.StatusUpdateTrackingDateTime).TotalMinutes > 30 && style.PlannedStartDateTime.Date == DateTime.Today)
                        {
                            operatorAccess.UpdateOperatorStatusByStatusName(style.OperatorID, "Idle");
                            new AlertAccess().InsertAlert("Idle", $"{style.SampleRequestNo} style is still waiting. {style.OperatorEPFName} Operator is Idle now.", "Operator", 1);
                        }
                        break;
                }
            }
        }

        private void alertBtn_Click(object sender, EventArgs e)
        {
            if (!isAlertSidebarOpen)
            {
                _alertSideBar.Visible = true;
                _alertSideBar.BringToFront();
                _alertSideBar.refreshallalerts();
            }
            else
            {
                _alertSideBar.Visible = false;
            }

            isAlertSidebarOpen = !isAlertSidebarOpen;
        }
    }
}
