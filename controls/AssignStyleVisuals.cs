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
using EyeonOps.form;
using EyeonOps.models;

namespace EyeonOps.controls
{
    public partial class AssignStyleVisuals : UserControl
    {
        private string sampleRequestNo;
        private string customerName;
        private string sampleFitType;
        private string styleNum;
        private int quantity;
        private int priorityNum;
        private DateTime? plannedStartDate;
        private DateTime? plannedFinishDate;

        public AssignStyleVisuals(Style style)
        {
            InitializeComponent();
            sampleRequestNo = style.SampleRequestNo;
            customerName = style.Customer;
            sampleFitType = style.SampleFitType;
            styleNum = style.StyleNo;
            quantity = style.Quantity;
            priorityNum = style.Priority ?? 0;
            plannedStartDate = style.PlannedStartDateTime;
            plannedFinishDate = style.PlannedFinishDateTime;

            sampleRequestNumber.Text = sampleRequestNo;
            customer.Text = customerName;
            fittype.Text = sampleFitType;
            styleNo.Text = styleNum;
            qty.Text = $"{quantity}";
            priority.Text = $"{priorityNum}";
            plannedStart.Text = $"Start: {plannedStartDate?.ToString("g") ?? "N/A"}";
            plannedFinish.Text = $"Finish: {plannedFinishDate?.ToString("g") ?? "N/A"}";

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color bodercolor = Color.Gray;

            switch (sampleFitType?.Trim().ToLower())
            {
                case "athletic fit":
                    bodercolor = ColorTranslator.FromHtml("#26c965");
                    break;
                case "regular fit":
                    bodercolor = ColorTranslator.FromHtml("#2698c9");
                    break;
                case "slim fit":
                    bodercolor = ColorTranslator.FromHtml("#ddd815");
                    break;
                case "loose fit":
                    bodercolor = ColorTranslator.FromHtml("#4a54ff");
                    break;
                default:
                    bodercolor = Color.Gray;
                    break;
            }

            using (Pen p = new Pen(bodercolor, 3))
            {
                // Draw border rectangle
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            IdleOperatorAssigningForm idleoperatorform = new IdleOperatorAssigningForm(sampleRequestNo, plannedStartDate, plannedFinishDate);
            idleoperatorform.ShowDialog();
        }
    }
}
