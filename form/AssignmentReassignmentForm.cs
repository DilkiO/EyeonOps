using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class AssignmentReassignmentForm : Form
    {
        public AssignmentReassignmentForm()
        {
            InitializeComponent();
        }

        private void AssignmentReassignmentForm_Load(object sender, EventArgs e)
        {
            List<Style> styles = new StyleAccess().GetHandOverStyles();
            foreach (Style style in styles) 
            {
                UserControl stylevisual = new AssignStyleVisuals(style);
                styleContainerPanel.Controls.Add(stylevisual);
            }
        }
    }
}
