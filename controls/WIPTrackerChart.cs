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
using DocumentFormat.OpenXml.InkML;
using EyeonOps.models;

namespace EyeonOps.controls
{
    public partial class WIPTrackerChart : UserControl
    {
        public DateTime Date { get; set; }= DateTime.Today ;
        public DateTime StartTime => Date.AddHours(8);
        public DateTime EndTime => Date.AddHours(22).AddMinutes(0);
        public List<Row> Rows { get; set; } = new List<Row>();

        private int RowHeight {  get; set; }=24;
        private int RowLabelWidth { get; set; } = 120;
        private int TopMargin { get; set; } = 40;
        private int TimePerColumn { get; set; } = 30;
        private int ColumnWidth { get; set; } = 50;
        private double SmallestTimeWidth => (double)ColumnWidth / (double)TimePerColumn;

        public event EventHandler<StyleTimeBlock> StyleTimeBlcokClicked;

        public WIPTrackerChart()
        {
            InitializeComponent();
        }
        public void VisualChart()
        {
            this.SuspendLayout();
            topPanel.Controls.Clear();
            chartPanel.Controls.Clear();
            
            int ChartHeight=Rows.Count*RowHeight;
            int ChartWidth = (int)(((double)(EndTime-StartTime).TotalMinutes/TimePerColumn)* ColumnWidth);
            
            chartPanel.Height = ChartHeight;
            chartPanel.Width = ChartWidth;

            topPanel.Height = TopMargin;
            topPanel.Width = ChartWidth;

            CreateTimeLineHeader();
            CreateRows();
            this.ResumeLayout();
        }
        private void CreateTimeLineHeader()
        {
            Panel separator = new Panel
            {
                Location = new Point(RowLabelWidth, 0),
                Width = 2,
                Height = TopMargin,
                BackColor = Color.FromArgb(180, 180, 180)
            };
            topPanel.Controls.Add(separator);

            for (DateTime time = StartTime; time <= EndTime; time = time.AddMinutes(TimePerColumn))
            {
                int x = RowLabelWidth + (int)(((double)(time - StartTime).TotalMinutes / TimePerColumn) * ColumnWidth);

                Label timeLabel = new Label
                {
                    Text = time.ToString("HH:mm\nddd"),
                    Location = new Point(x, 0),
                    Width = ColumnWidth,
                    Height = TopMargin,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 8f, FontStyle.Bold),
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.None
                };

                topPanel.Controls.Add(timeLabel);

                // Add vertical grid line
                Panel gridLine = new Panel
                {
                    Location = new Point(x, 0),
                    Width = 1,
                    Height = TopMargin,
                    BackColor = Color.FromArgb(200, 200, 200)
                };
                topPanel.Controls.Add(gridLine);
            }
        }
        private void CreateRows()
        {
            for (int i=0; i<Rows.Count;i++)
            {
                Row row = Rows[i];
                int y = i * RowHeight;

                // Create row background
                Panel rowPanel = new Panel
                {
                    Location = new Point(0, y),
                    Width = RowLabelWidth + ((int)(EndTime - StartTime).TotalMinutes / TimePerColumn + 1) * ColumnWidth,
                    Height = RowHeight,
                    BackColor = i % 2 == 0 ? Color.FromArgb(245, 245, 245) : Color.White,
                    BorderStyle = BorderStyle.None,
                    AutoScroll = false
                };
                chartPanel.Controls.Add(rowPanel);

                // Create row label
                Label rowLabel = new Label
                {
                    Text = row.Label,
                    Width = RowLabelWidth - 10,
                    Height = RowHeight,
                    Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.Transparent
                };
                rowLabel.Location = new Point(5, (RowHeight - rowLabel.Height) / 2);
                rowPanel.Controls.Add(rowLabel);
                rowLabel.BringToFront();

                Panel separator = new Panel
                {
                    Location = new Point(RowLabelWidth, 0),
                    Width = 2,
                    Height = RowHeight,
                    BackColor = Color.FromArgb(200, 200, 200)
                };
                rowPanel.Controls.Add(separator);
                separator.BringToFront();

                // Create grid lines
                for (DateTime d = StartTime; d <= EndTime; d = d.AddMinutes(TimePerColumn))
                {
                    int x = RowLabelWidth + (int)(((double)(d - StartTime).TotalMinutes / TimePerColumn) * ColumnWidth);

                    Panel gridLine = new Panel
                    {
                        Location = new Point(x, 0),
                        Width = 1,
                        Height = RowHeight,
                        BackColor = Color.FromArgb(230, 230, 230)
                    };
                    rowPanel.Controls.Add(gridLine);
                }

                // Now Time Grid Line
                DateTime now = DateTime.Now;
                for (DateTime d = StartTime; d <= EndTime; d = d.AddMinutes(1))
                {
                    int x = RowLabelWidth + (int)(((double)(d - StartTime).TotalMinutes) * SmallestTimeWidth);

                    Panel nowTimegridLine = new Panel
                    {
                        Location = new Point(x, 0),
                        Width = 2,
                        Height = RowHeight,
                        BackColor = Color.Red
                    };
                    if (Math.Abs((d - now).TotalMinutes) < 1)
                    {
                        rowPanel.Controls.Add(nowTimegridLine);
                        nowTimegridLine.BringToFront();
                        break;
                    }
                }

                // Create time blocks
                foreach (var block in row.StyleTimeBlocks)
                {
                    if (block.PlannedStartTime.Date > Date.Date) continue;
                    int x = RowLabelWidth + (int)(((double)(block.PlannedStartTime - StartTime).TotalMinutes) * SmallestTimeWidth);
                    int width = Math.Max(ColumnWidth, (int)(((double)(block.PlannedEndTime - block.PlannedStartTime).TotalMinutes) * SmallestTimeWidth));

                    StyleBlockVisual blockPanel = new StyleBlockVisual(block)
                    {
                        Width = width - 4,
                        Height = RowHeight - 6
                    };
                    blockPanel.Location = new Point(x + 2, (RowHeight - blockPanel.Height) / 2);

                    blockPanel.StyleBlockClicked += (s, e) =>
                    {
                        StyleTimeBlcokClicked?.Invoke(this, block);
                        MessageBox.Show($"Clicked: {block.Label}\nStart: {block.PlannedStartTime.ToString("dd[ddd] HH:mm:ss")}\nEnd: {block.PlannedEndTime.ToString("dd[ddd] HH:mm:ss")}",
                                        "Style Block Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    };

                    rowPanel.Controls.Add(blockPanel);
                }
            }
        }

        public void Dispose2(bool disposing)
        {
            if (disposing)
            {
                foreach (Control c in this.Controls)
                    c.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
