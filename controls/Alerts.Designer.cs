namespace EyeonOps.controls
{
    partial class AlertVisual
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
            typeLabel = new Label();
            acknowledgedBtn = new Button();
            meassageLabel = new Label();
            entityTypelabel = new Label();
            resolvedBtn = new Button();
            SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            typeLabel.Location = new Point(12, 8);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(42, 20);
            typeLabel.TabIndex = 0;
            typeLabel.Text = "Type\r\n";
            typeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // acknowledgedBtn
            // 
            acknowledgedBtn.FlatAppearance.BorderSize = 0;
            acknowledgedBtn.FlatStyle = FlatStyle.Flat;
            acknowledgedBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acknowledgedBtn.ForeColor = Color.Red;
            acknowledgedBtn.Location = new Point(254, 3);
            acknowledgedBtn.Name = "acknowledgedBtn";
            acknowledgedBtn.Size = new Size(43, 31);
            acknowledgedBtn.TabIndex = 1;
            acknowledgedBtn.Text = "🔕";
            acknowledgedBtn.UseVisualStyleBackColor = true;
            acknowledgedBtn.Click += acknowledgedBtn_Click;
            // 
            // meassageLabel
            // 
            meassageLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            meassageLabel.ForeColor = Color.White;
            meassageLabel.Location = new Point(16, 32);
            meassageLabel.Name = "meassageLabel";
            meassageLabel.Size = new Size(266, 53);
            meassageLabel.TabIndex = 2;
            meassageLabel.Text = "Message";
            meassageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entityTypelabel
            // 
            entityTypelabel.AutoSize = true;
            entityTypelabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entityTypelabel.ForeColor = Color.FromArgb(192, 192, 255);
            entityTypelabel.Location = new Point(12, 89);
            entityTypelabel.Name = "entityTypelabel";
            entityTypelabel.Size = new Size(65, 15);
            entityTypelabel.TabIndex = 3;
            entityTypelabel.Text = "Entity Type";
            entityTypelabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // resolvedBtn
            // 
            resolvedBtn.FlatAppearance.BorderSize = 0;
            resolvedBtn.FlatStyle = FlatStyle.Flat;
            resolvedBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resolvedBtn.ForeColor = Color.Lime;
            resolvedBtn.Location = new Point(254, 80);
            resolvedBtn.Name = "resolvedBtn";
            resolvedBtn.Size = new Size(43, 31);
            resolvedBtn.TabIndex = 4;
            resolvedBtn.Text = "✔️";
            resolvedBtn.UseVisualStyleBackColor = true;
            resolvedBtn.Click += resolvedBtn_Click;
            // 
            // AlertVisual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(resolvedBtn);
            Controls.Add(entityTypelabel);
            Controls.Add(meassageLabel);
            Controls.Add(acknowledgedBtn);
            Controls.Add(typeLabel);
            Margin = new Padding(8, 8, 8, 0);
            Name = "AlertVisual";
            Size = new Size(298, 116);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label typeLabel;
        private Button acknowledgedBtn;
        private Label meassageLabel;
        private Label entityTypelabel;
        private Button resolvedBtn;
    }
}
