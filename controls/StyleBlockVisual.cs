using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeonOps.models;

namespace EyeonOps.controls
{
    public partial class StyleBlockVisual : UserControl
    {
        public StyleTimeBlock StyleTimeBlock { get; set; }
        private Label label;
        public event EventHandler StyleBlockClicked;

        public StyleBlockVisual()
        {
            InitializeComponent();
        }

        public StyleBlockVisual(StyleTimeBlock styleTimeBlock)
        {
            StyleTimeBlock = styleTimeBlock;
            this.BackColor = styleTimeBlock.Color;

            label = new Label
            {
                Text = styleTimeBlock.Label,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = GetContrastColor(styleTimeBlock.Color),
                Font = new Font("Segoe UI", 8f, FontStyle.Bold),
                Padding = new Padding(this.Width / 2, 0, 5, 0),
                BackColor = Color.Transparent,
            };

            this.Controls.Add(label);

            this.MouseEnter += (s, e) => {
                this.BackColor = ControlPaint.Light(styleTimeBlock.Color, 0.2f);
            };

            this.Click += (s, e) => StyleBlockClicked?.Invoke(this, EventArgs.Empty);
            label.Click += (s, e) => StyleBlockClicked?.Invoke(this, EventArgs.Empty);
        }
        private Color GetContrastColor(Color color)
        {
            double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
            return luminance > 0.5 ? Color.Black : Color.White;
        }
    }
}
