namespace EyeonOps.controls
{
    partial class AssignStyleVisuals
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sampleRequestNumber = new Label();
            styleNo = new Label();
            fittype = new Label();
            qty = new Label();
            planned = new Label();
            plannedStart = new Label();
            plannedFinish = new Label();
            customer = new Label();
            priority = new Label();
            assignBtn = new Button();
            SuspendLayout();
            // 
            // sampleRequestNumber
            // 
            sampleRequestNumber.BackColor = Color.Transparent;
            sampleRequestNumber.Location = new Point(-2, 23);
            sampleRequestNumber.Margin = new Padding(0);
            sampleRequestNumber.Name = "sampleRequestNumber";
            sampleRequestNumber.Size = new Size(185, 24);
            sampleRequestNumber.TabIndex = 0;
            sampleRequestNumber.Text = "Sample Request No";
            sampleRequestNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // styleNo
            // 
            styleNo.BackColor = Color.Transparent;
            styleNo.Location = new Point(-2, 47);
            styleNo.Margin = new Padding(0);
            styleNo.Name = "styleNo";
            styleNo.Size = new Size(185, 24);
            styleNo.TabIndex = 1;
            styleNo.Text = "Style No";
            styleNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fittype
            // 
            fittype.BackColor = Color.Transparent;
            fittype.Location = new Point(-2, 71);
            fittype.Margin = new Padding(0);
            fittype.Name = "fittype";
            fittype.Size = new Size(185, 24);
            fittype.TabIndex = 2;
            fittype.Text = "Fit Type";
            fittype.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // qty
            // 
            qty.BackColor = Color.Transparent;
            qty.Location = new Point(-2, 95);
            qty.Margin = new Padding(0);
            qty.Name = "qty";
            qty.Size = new Size(185, 24);
            qty.TabIndex = 3;
            qty.Text = "Qty";
            qty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // planned
            // 
            planned.BackColor = Color.Transparent;
            planned.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            planned.Location = new Point(-2, 119);
            planned.Margin = new Padding(0);
            planned.Name = "planned";
            planned.Padding = new Padding(10, 0, 0, 0);
            planned.Size = new Size(185, 24);
            planned.TabIndex = 4;
            planned.Text = "Planned";
            planned.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // plannedStart
            // 
            plannedStart.BackColor = Color.Transparent;
            plannedStart.Location = new Point(-2, 143);
            plannedStart.Margin = new Padding(0);
            plannedStart.Name = "plannedStart";
            plannedStart.Size = new Size(185, 24);
            plannedStart.TabIndex = 5;
            plannedStart.Text = "Start";
            plannedStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plannedFinish
            // 
            plannedFinish.BackColor = Color.Transparent;
            plannedFinish.Location = new Point(-2, 167);
            plannedFinish.Margin = new Padding(0);
            plannedFinish.Name = "plannedFinish";
            plannedFinish.Size = new Size(185, 24);
            plannedFinish.TabIndex = 6;
            plannedFinish.Text = "Finish";
            plannedFinish.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customer
            // 
            customer.BackColor = Color.Transparent;
            customer.Location = new Point(-2, -1);
            customer.Margin = new Padding(0);
            customer.Name = "customer";
            customer.Size = new Size(185, 24);
            customer.TabIndex = 7;
            customer.Text = "Customer";
            customer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priority
            // 
            priority.BackColor = Color.Transparent;
            priority.Location = new Point(-2, 191);
            priority.Margin = new Padding(0);
            priority.Name = "priority";
            priority.Size = new Size(185, 24);
            priority.TabIndex = 8;
            priority.Text = "Priority";
            priority.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // assignBtn
            // 
            assignBtn.AutoSize = true;
            assignBtn.BackColor = Color.Black;
            assignBtn.FlatStyle = FlatStyle.Flat;
            assignBtn.ForeColor = Color.White;
            assignBtn.Location = new Point(105, 222);
            assignBtn.Name = "assignBtn";
            assignBtn.Size = new Size(75, 27);
            assignBtn.TabIndex = 9;
            assignBtn.Text = "Assign";
            assignBtn.UseVisualStyleBackColor = false;
            assignBtn.Click += assignBtn_Click;
            // 
            // AssignStyleVisuals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(assignBtn);
            Controls.Add(priority);
            Controls.Add(customer);
            Controls.Add(plannedFinish);
            Controls.Add(plannedStart);
            Controls.Add(planned);
            Controls.Add(qty);
            Controls.Add(fittype);
            Controls.Add(styleNo);
            Controls.Add(sampleRequestNumber);
            Margin = new Padding(8);
            Name = "AssignStyleVisuals";
            Size = new Size(183, 252);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sampleRequestNumber;
        private Label styleNo;
        private Label fittype;
        private Label qty;
        private Label planned;
        private Label plannedStart;
        private Label plannedFinish;
        private Label customer;
        private Label priority;
        private Button assignBtn;
    }
}
