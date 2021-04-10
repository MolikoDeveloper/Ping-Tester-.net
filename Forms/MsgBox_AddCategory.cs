using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyromorphite.Forms
{
    public partial class MsgBox_AddCategory : Form
    {
        public MsgBox_AddCategory()
        {
            InitializeComponent();
        }

        #region DragScreen
        private bool _mousedown;
        private Point _lastLocation;

        private void mousedown(object sender, MouseEventArgs e)
        {
            _mousedown = true;
            _lastLocation = e.Location;
        }
        private void mouseUp(object sender, MouseEventArgs e)
        {
            this._mousedown = false;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (_mousedown)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.Location = new Point(
                        (this.Location.X - _lastLocation.X) + e.X,
                        (this.Location.Y - _lastLocation.Y) + e.Y);
                    this.Update();
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    _lastLocation = new Point(300, 15);
                }
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
