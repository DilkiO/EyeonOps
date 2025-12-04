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
    public partial class AlertVisual : UserControl
    {
        public event Action RefreshAllAlerts;

        private Alert _alert;
        public AlertVisual(Alert alert)
        {
            InitializeComponent();
            typeLabel.Text = alert.Type;
            meassageLabel.Text = alert.Message;
            entityTypelabel.Text = alert.EntityType;
            _alert = alert;

            if (alert.Status == "Unread")
            {
                Color ackColor = ColorTranslator.FromHtml("#FFF2C9");
                ApplyBackgroundColor(this, ackColor);

                meassageLabel.ForeColor = Color.Black;
                entityTypelabel.ForeColor = Color.Navy;
            }
        }

        private void ApplyBackgroundColor(Control parent, Color color)
        {
            parent.BackColor = color;

            foreach (Control ctrl in parent.Controls)
            {
                ctrl.BackColor = color;
                if (ctrl.HasChildren)
                    ApplyBackgroundColor(ctrl, color);
            }
        }
        private void acknowledgedBtn_Click(object sender, EventArgs e)
        {
            ApplyBackgroundColor(this, Color.RoyalBlue);
            meassageLabel.ForeColor = Color.White;
            entityTypelabel.ForeColor = Color.FromArgb(192, 192, 255);

            new AlertAccess().UpdateAlertStatus(_alert.AlertID, "Acknowledged");
            _alert.Status = "Acknowledged";
        }

        private void resolvedBtn_Click(object sender, EventArgs e)
        {
            new AlertAccess().UpdateAlertStatus(_alert.AlertID, "Resolved");
            _alert.Status = "Resolved";
            RefreshAllAlerts?.Invoke();
        }
    }
}
