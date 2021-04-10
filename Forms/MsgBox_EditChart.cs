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
    public partial class MsgBox_EditChart : Form
    {
        

        public MsgBox_EditChart()
        {
            InitializeComponent();
            bt_Delete.Image = imageList1.Images[0];
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
