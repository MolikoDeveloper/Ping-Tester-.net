using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyromorphite.Controls.Item
{
    public partial class RoundedButton : Button
    {
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        public bool Outline = false;
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        public float OutlineWidht=0;

        public bool Rounded = true;
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        public int radius = 30;

        protected override bool ShowFocusCues{get{return false;}}

        

        public RoundedButton():base()
        {
            this.InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, false);
        }

        GraphicsPath GetRoundPath(RectangleF Rect)
        {
            float r2 = radius / 2f;

            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            if (Rounded)
            {
                RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
                using (GraphicsPath GraphPath = GetRoundPath(Rect))
                {
                    this.Region = new Region(GraphPath);
                    if (Outline)
                        using (Pen pen = new Pen(MColor.Blue, OutlineWidht))
                        {
                            pen.Alignment = PenAlignment.Inset;
                            e.Graphics.DrawPath(pen, GraphPath);
                        }
                }
            }
        }
    }
}
