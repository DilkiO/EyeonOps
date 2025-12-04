using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeonOps.data;
using EyeonOps.models;

namespace EyeonOps.controls
{
    public partial class alertSideBarControl : UserControl
    {
        public void refreshallalerts()
        {
            List<Alert> alertslist = new AlertAccess().GetAllAlerts();
            alterContainerPanel.Controls.Clear();
            foreach (Alert al in alertslist)
            {
                AlertVisual alertVisual = new AlertVisual(al);
                alertVisual.RefreshAllAlerts += refreshallalerts;
                alterContainerPanel.Controls.Add(alertVisual);
            }
        }
        public alertSideBarControl()
        {
            InitializeComponent();
        }

        private void alertSideBarControl_Load(object sender, EventArgs e)
        {
            refreshallalerts();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear all alerts?","Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            new AlertAccess().DeleteAllAlert();
            alterContainerPanel.Controls.Clear();
        }
    }
}
