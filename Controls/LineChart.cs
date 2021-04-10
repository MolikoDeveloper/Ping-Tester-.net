using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using Pyromorphite.Forms;

namespace Pyromorphite.Controls
{
    public partial class LineChart : UserControl
    {
        public bool enabled = true;

        public bool IpToPort=false;

        public string tag { get; set; }
        Ping pinger;
        Timer timer;

        public int interval = 1;

        public LineChart()
        {
            InitializeComponent();
            this.Load += LineChart_Load;
        }

        public void LineChart_Load(object sender, EventArgs e)
        {
            pinger = new Ping();
            timer = new Timer();
            pinger.PingCompleted += Pinger_PingCompleted;

            timer.Tick += new EventHandler(delegate (object _sender, EventArgs _e)
            {
                Ping(this.txt_ip.Text, interval);
            });
            timer.Interval = (interval * 1000) + 1000; //interval + 1seg seg           
            timer.Start();
        }

        public void Reset()
        {
            if (timer.Enabled)
            {
                timer.Stop();
                timer.Interval = (interval * 1000) + 1000;
                this.Refresh();
                timer.Start();
            }
        }

        #region Edit
        //Edit button
        private void bt_Edit_Click(object sender, EventArgs e)
        {
            using (MsgBox_EditChart editor = new MsgBox_EditChart())
            {
                editor.bt_Confirm.Click += BT_Confirm_Edit;
                editor.bt_Delete.Click += Bt_Delete_Click;

                editor.txt_ip.Text = this.txt_ip.Text;
                editor.txt_name.Text = this.nombre.Text;

                editor.ShowDialog();
            }
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            ((Control)sender).FindForm().Dispose();
            this.DisposeAll();
        }

        //Confirm Changes
        private void BT_Confirm_Edit(object sender, EventArgs e)
        {
            var form = (MsgBox_EditChart)((Control)sender).FindForm();

            this.txt_ip.Text = form.txt_ip.Text;
            this.nombre.Text = form.txt_name.Text;

            this.Refresh();
            this.chart1.Refresh();
            form.Close();
            form.Dispose();
        }

        #endregion
        #region ping
        public void Ping(string ip, int UpdateTime)
        {
            try {
                pinger.SendPingAsync(ip, UpdateTime);
            }
            catch (Exception e)
            {
                Console.WriteLine("void Ping Error: "+e.Message);
            }

        }
        private void Pinger_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            try
            {
                if (e.Reply != null)
                {
                    chart1.AddPoint(e.Reply.Status);
                }
                else
                {
                    chart1.AddPoint(IPStatus.BadDestination);
                }
                pinger.SendAsyncCancel();
            }
            catch (Exception error)
            {
                Console.WriteLine("void Pinger_PingCompleted error: " + error.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port">default 80</param>
        /// <returns></returns>
        public bool PingPort(string host, int port)
        {
            try
            {
                using (var client = new TcpClient(host, port))
                {
                    if (client.Connected)
                        return true;
                    else
                        return false;
                }
            }
            catch(SocketException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        #endregion

        public void DisposeAll ()
        {
            this.Parent = null;
            this.timer.Dispose();
            this.pinger.Dispose();
            this.Dispose();
        }
    }
}
