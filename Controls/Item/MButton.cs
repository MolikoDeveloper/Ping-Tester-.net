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
    public partial class MButton : Button
    {
        protected override bool ShowFocusCues{get{return false;}}

        public MButton():base()
        {
            this.InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, false);
        }
    }
}
