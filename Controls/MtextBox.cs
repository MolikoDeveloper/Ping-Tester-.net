using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyromorphite.Controls
{
    public partial class MtextBox : UserControl
    {
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        public override string Text { get { return this.textBox1.Text; } set{ this.textBox1.Text = value; }}

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        public HorizontalAlignment TextAlign { get { return this.textBox1.TextAlign; } set { this.textBox1.TextAlign = value; } }

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        public override Color BackColor { get => textBox1.BackColor; set => textBox1.BackColor = value; }

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        public override Color ForeColor { get => textBox1.ForeColor; set => textBox1.ForeColor = value; }

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        public override Font Font { get => textBox1.Font; set => textBox1.Font = value; }

        public MtextBox()
        {
            InitializeComponent();
        }
    }
}
