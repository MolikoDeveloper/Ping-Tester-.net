using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace Pyromorphite.Controls
{
    public partial class CategoryButton : UserControl
    {
        public override string Text { get { return this.label1.Text; } set { this.label1.Text = value; } }
        protected override bool ShowFocusCues { get { return false; } }

        public CategoryButton()
        {
            InitializeComponent();
            AddFont(global::Pyromorphite.Properties.Resources.MolikoFont2);
            this.SetStyle(ControlStyles.Selectable, false);
            this.edit.Paint += Button1_Paint;
        }

        private void Button1_Paint(object sender, PaintEventArgs e)
        {
            sizeTextToControl(edit,e.Graphics, 10);
        }

        #region font
        internal static Font sizeTextToControl(Control control, Graphics graphic, int padding)
        {
            // Create a small font
            Font font;
            font = new Font(control.Font.FontFamily, 6.0f, control.Font.Style);
            SizeF textSize = graphic.MeasureString(control.Text, font);
            // Loop until it fits perfect
            while ((textSize.Width < control.Width - padding) && (textSize.Height < control.Height - padding))
            {
                font = new Font(font.FontFamily, font.Size + 0.5f, font.Style);
                textSize = graphic.MeasureString(control.Text, font);
            }
            font = new Font(font.FontFamily, font.Size - 0.5f, font.Style);
            return font;
        }

        private PrivateFontCollection _privateFontCollection = new PrivateFontCollection();

        public FontFamily GetFontFamilyByName(string name)
        {
            return _privateFontCollection.Families.FirstOrDefault(x => x.Name == name);
        }

        public void AddFont(string fullFileName)
        {
            AddFont(File.ReadAllBytes(fullFileName));
        }

        public void AddFont(byte[] fontBytes)
        {
            var handle = GCHandle.Alloc(fontBytes, GCHandleType.Pinned);
            IntPtr pointer = handle.AddrOfPinnedObject();
            try
            {
                _privateFontCollection.AddMemoryFont(pointer, fontBytes.Length);
            }
            finally
            {
                handle.Free();
            }
        }
        #endregion

        private void edit_Click(object sender, EventArgs e)
        {

        }
        public string ToString()
        {
            return this.label1.Text;
        }
    }
}
