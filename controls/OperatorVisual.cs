using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using EyeonOps.models;

namespace EyeonOps.controls
{
    public partial class OperatorVisual : UserControl
    {
        private string epfName;
        private string status;
        private string sampleRoom;
        private string grade;
        private string skill;
        private string idleTime;

        private Color borderColor = Color.Gray;
        private int borderWidth = 3;
        public OperatorVisual(Operator operatorData)
        {
            InitializeComponent();

            epfName = operatorData.OperatorEPFName;
            status = operatorData.Status;
            sampleRoom = operatorData.SampleRoom;
            grade = operatorData.Grade;
            skill = operatorData.Sequence;
            TimeSpan idleSpan = (TimeSpan)(DateTime.Now - operatorData.StatusUpdateDateTime) - new TimeSpan(5, 30, 0);
            idleTime = operatorData.Status == "Idle"? $"{(int)idleSpan.TotalHours:00}:{idleSpan.Minutes:00}": "No Idle Time";

            switch (status)
            {
                case "Active":
                    borderColor = Color.Green;
                    break;
                case "Idle":
                    borderColor = Color.Red;
                    break;
                case "Waiting":
                    borderColor = Color.Orange;
                    break;
                default:
                    borderColor = Color.FromArgb(150,150,150);
                    break;
            }

            this.Load += OperatorView_Load;

            this.DoubleBuffered = true;
        }

        private void OperatorView_Load(object sender, EventArgs e)
        {
            labelEPFName.Text = $"EPF No: {epfName}";
            labelStatus.Text = $"Name: {status}";
            labelSampleRoom.Text = $"Sample Room: {sampleRoom}";
            labelGrade.Text = $"Grade: {grade}";
            labelSkill.Text = $"Skill: {skill}";
            labelIdleTime.Text = $"Ilde Time: {idleTime}";
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}
