namespace EyeonOps.form
{
    partial class ImportOperatorsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportOperatorsForm));
            importedExcelFilePreview = new DataGridView();
            applyBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)importedExcelFilePreview).BeginInit();
            SuspendLayout();
            // 
            // importedExcelFilePreview
            // 
            importedExcelFilePreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            importedExcelFilePreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            importedExcelFilePreview.Location = new Point(12, 12);
            importedExcelFilePreview.Name = "importedExcelFilePreview";
            importedExcelFilePreview.Size = new Size(776, 393);
            importedExcelFilePreview.TabIndex = 3;
            // 
            // applyBtn
            // 
            applyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            applyBtn.AutoSize = true;
            applyBtn.BackColor = Color.Black;
            applyBtn.FlatStyle = FlatStyle.Flat;
            applyBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            applyBtn.ForeColor = Color.White;
            applyBtn.Location = new Point(713, 409);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(75, 29);
            applyBtn.TabIndex = 2;
            applyBtn.Text = "Apply";
            applyBtn.UseVisualStyleBackColor = false;
            applyBtn.Click += applyBtn_Click;
            // 
            // ImportOperatorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(importedExcelFilePreview);
            Controls.Add(applyBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ImportOperatorsForm";
            Text = "Import Operators";
            ((System.ComponentModel.ISupportInitialize)importedExcelFilePreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView importedExcelFilePreview;
        private Button applyBtn;
    }
}