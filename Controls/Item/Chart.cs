using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Linq;

namespace Pyromorphite.Controls.Item
{
    public partial class Chart : UserControl
    {
        
        public Graphics graphics { get; private set; }

        PointF LastTemp = new PointF(0, 0);
        public List<PointF> results = new List<PointF>();
        float sep;

        public Chart()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            this.Paint += Chart_Paint;
            LastTemp = new PointF(percentpanel(10).X, this.Height - 10);
            sep = percentpanel(10).X+20;
            //results.Add(LastTemp);
        }

        private void Chart_Paint(object sender, PaintEventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            graphics.Clear(this.BackColor);
            List<PointF> ChartDesign = new List<PointF>();
            Pen pen = new Pen(MColor.BlueIce , 1);

            graphics.Clear(MColor.DarkGray);

            Font drawfont = new Font("Stencil", 7);
            SolidBrush brush = new SolidBrush(Color.White);

            graphics.DrawString("OK", drawfont, brush, new PointF(0, 10));
            graphics.DrawString("T.O", drawfont, brush, new PointF(0, (this.Size.Height / 2) - 5));
            graphics.DrawString("Er", drawfont, brush, new PointF(0, this.Size.Height - 20));


            ChartDesign.Add(new PointF(percentpanel(10).X, 10));//Punto Y 1
            ChartDesign.Add(new PointF(percentpanel(10).X, this.Height - 10));//Punto Y 2
            ChartDesign.Add(new PointF(179, this.Size.Height - 10));
            graphics.DrawLine(pen, ChartDesign[0], ChartDesign[1]);
            graphics.DrawLine(pen, ChartDesign[1], ChartDesign[2]);

            showall();
        }

        public void RestartChart()
        {
            results = new List<PointF>();
        }

        public void AddPoint(IPStatus ipStatus)
        {
            Pen pen;
            if (results.Count <= 7)
            {
                pen = new Pen(MColor.Green, 1f);
                switch (ipStatus)
                {
                    case IPStatus.Success:
                    results.Add(new PointF(sep, 10));
                    break;
                    case IPStatus.TimedOut:
                    results.Add(new PointF(sep, (this.Size.Height / 2) - 5));
                    break;
                    default:
                    results.Add(new PointF(sep, this.Size.Height - 11));
                    break;
                }
                graphics.DrawLine(pen, LastTemp, results.Last());
                LastTemp = results.Last();
                sep += 20;

            }
            else //mostrar si exede el maximo en pantalla.
            {
                Reset();
                //  results.Remove(results.First());
                pen = new Pen(Color.Red, 2);
                sep = percentpanel(10).X + 20;

                for (int i = 0; i < results.Count-1; i++)
                {
                    
                        results[i] = new PointF(sep, results[i+1].Y);
                        sep += 20;
                }

                results[0] = new PointF(percentpanel(10).X+1,results[0].Y);
                
                switch (ipStatus)
                {
                    case IPStatus.Success:
                        results[results.Count-1] = new PointF(sep, 10);
                    break;
                    case IPStatus.TimedOut:
                        results[results.Count - 1] = new PointF(sep, (this.Size.Height / 2) - 5);
                    break;
                    default:
                        results[results.Count - 1] = new PointF(sep, this.Size.Height - 11);
                    break;
                }
                //graphics.DrawLines(pen, results.ToArray());
            }
        }

        void showall()
        {
            Pen pen = new Pen(MColor.Green, 1f);
            if(results.Count >1)
                graphics.DrawLines(pen, results.ToArray());
        }

        PointF percentpanel(int divs)
        {
            //porcentaje*total/100=actual
            return new PointF((divs * this.Size.Width) / 100, (divs * this.Size.Height) / 100);
        }

    }
}
