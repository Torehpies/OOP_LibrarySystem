using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.Black;
        public int BorderSize { get; set; } = 1;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int diameter = BorderRadius * 2;
            Rectangle arcRect = new Rectangle(0, 0, diameter, diameter);

            GraphicsPath path = new GraphicsPath();

            // Top-left arc
            path.AddArc(arcRect, 180, 90);

            // Top-right arc
            arcRect.X = this.Width - diameter;
            path.AddArc(arcRect, 270, 90);

            // Bottom-right arc
            arcRect.Y = this.Height - diameter;
            path.AddArc(arcRect, 0, 90);

            // Bottom-left arc
            arcRect.X = 0;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();

            this.Region = new Region(path);

            // Fill the panel
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Draw the border
            if (BorderSize > 0)
            {
                using (Pen pen = new Pen(BorderColor, BorderSize))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
