using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Pyromorphite.Controls;
using Pyromorphite.Controls.Item;
using Pyromorphite.Forms;

namespace Pyromorphite
{
    public partial class Form1 : Form
    {
        private int waitTime = 1;

        private string OwnFile=string.Empty;

        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown; ;
            ButtonPanel.AutoScroll = true;
            ButtonPanel.VerticalScroll.Enabled = false;
            ButtonPanel.VerticalScroll.Visible = false;
        }

        public Form1(string file)
        {
            InitializeComponent();
            this.OwnFile = file;
            LoadFile(file);
        }

        #region File
        private void SaveFile(string FilePath)
        {

            List<CategoryButton> buttons = this.CategoryPanel.Controls.OfType<CategoryButton>().ToList();
            List<LineChart> lineCharts = this.ButtonPanel.Controls.OfType<LineChart>().ToList();
            
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.OmitXmlDeclaration = true;
            xws.Indent = true;

            using (XmlWriter xw = XmlWriter.Create(sb, xws))
            {
                XDocument doc = new XDocument();
                XElement root = new XElement("Root", new XAttribute("WaitTime", waitTime));


                for (int i = 0; i < buttons.Count; i++)
                {
                    root.Add(new XElement("Category", new XAttribute("Name", buttons[i].ToString())));
                    if (!buttons[i].IsDisposed)
                    {
                        for (int y = 0; y < lineCharts.Count(); y++)
                        {
                            if (lineCharts[y].tag == buttons[i].ToString() && !lineCharts[y].IsDisposed) 
                            {
                                root.Elements().Last().Add(
                                    new XElement("Device",
                                    new XAttribute("Category", buttons[i].ToString()),
                                    new XElement("Name", lineCharts[y].nombre.Text),
                                    new XElement("IP", lineCharts[y].txt_ip.Text)
                                    ));
                            }
                        }
                    }
                }
                doc.Add(root);
                doc.Save(xw);
            }
            if (FilePath != string.Empty)
            {
                Console.WriteLine(sb.ToString());
                File.WriteAllText(FilePath, sb.ToString());
            }
        }
        
        private void LoadFile(string FilePath)
        {
            //reset All
            Clear();
            //load all
            try
            {
                XDocument doc = XDocument.Load(FilePath);

                this.waitTime = int.Parse(doc.Root.Attribute("WaitTime").Value);
                
                var cat = doc.Descendants("Category");
                var IPs = doc.Elements().Descendants("Device");

                foreach(var category in cat)
                {
                    CategoryButton CatButton = new CategoryButton()
                    {
                        Name = category.Attribute("Name").Value,
                        Text = category.Attribute("Name").Value
                    };
                    CatButton.label1.Text = CatButton.Text;

                    int zIndex = CategoryPanel.Controls.GetChildIndex(Left_Button_add);

                    CatButton.label1.Click += FiltrarCategoria;
                    CatButton.Paint += Catbutton_Paint;
                    CategoryPanel.Controls.Add(CatButton);
                    CategoryPanel.Controls.SetChildIndex(Left_Button_add, zIndex + 1);
                   // CatButton.Show();
                    Console.WriteLine("OK?");
                }

                foreach (var ip in IPs)
                {
                    int zIndex = ButtonPanel.Controls.GetChildIndex(AddIPButton);
                    LineChart IpButton = new LineChart()
                    {
                        interval = waitTime,
                        Enabled = true,
                        tag = ip.Attribute("Category").Value
                    };
                    IpButton.nombre.Text = ip.Element("Name").Value;
                    IpButton.txt_ip.Text = ip.Element("IP").Value;

                    ButtonPanel.Controls.Add(IpButton);
                    ButtonPanel.Controls.SetChildIndex(AddIPButton, zIndex + 1);
                }

                this.bt_ShowAll.Visible = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void Clear()
        {
            this.AddIPButton.Visible = false;
            this.bt_ShowAll.Visible = false;
            foreach (LineChart chart in this.ButtonPanel.Controls.OfType<LineChart>())
            {
                chart.DisposeAll();
                chart.Parent = this;
            }
            foreach (CategoryButton cat in this.CategoryPanel.Controls.OfType<CategoryButton>().ToArray())
            {
                cat.Dispose();
                cat.Parent = this;
            }
            this.Titulo.Text = "todos los equipos";
            this.Refresh();
        }
        #endregion

        #region DragScreenControl
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

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FullScreen();
        }
        private void FullScreen()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
                Rectangle FromControl = Screen.FromControl(this).WorkingArea;
                rect.Location = new Point(0, 0);
                FromControl.Location = rect.Location;
                //this.MaximizedBounds = FromControl;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        #endregion

        #region TopBarButtons
        private void CloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimizar
        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Key
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.Enter)
                FullScreen();
        }
        #endregion

        #region AppButtons
        //Agregar IP
        private void AddChartIP(object sender, EventArgs e)
        {
            Control control = ((Control)sender);
            Control parent = control.Parent;
            int zIndex = parent.Controls.GetChildIndex(control);

            using (MsgBox_AddChart newChart = new MsgBox_AddChart())
            {

                newChart.bt_Confirm.Click += new EventHandler(delegate (object o, EventArgs a)
                {
                    if (newChart.txt_name.Text != string.Empty && newChart.txt_ip.Text != string.Empty)
                    {
                        LineChart IpButton = new LineChart()
                        {
                            interval = waitTime,
                            Enabled = true,
                            tag = this.Titulo.Text
                        };

                        IpButton.nombre.Text = newChart.txt_name.Text;
                        IpButton.txt_ip.Text = newChart.txt_ip.Text;

                        parent.Controls.Add(IpButton);

                        newChart.Close();
                    }
                    else
                    {
                        return;
                    }
                });

                newChart.ShowDialog();
            }
            
            parent.Controls.SetChildIndex(control, zIndex+1);
        }

        //Agregar Categoria Boton
        private void AddCategory(object sender, EventArgs e)
        {

            Control control = ((Control)sender);
            Control parent = control.Parent;
            int zIndex = parent.Controls.GetChildIndex(control);

            //mostrar formulario y crear boton
            using (MsgBox_AddCategory NewCatForm = new MsgBox_AddCategory())
            {
                //Agregar Boton de categoria.
                NewCatForm.bt_Confirm.Click += new EventHandler(delegate (object o, EventArgs a)
               {
                   if (NewCatForm.textBox1.Text != string.Empty)
                   {
                       CategoryButton catbutton = new CategoryButton()
                       {
                           // FlatStyle = Left_Button_add.FlatStyle,
                           Text = NewCatForm.textBox1.Text,
                           Name = NewCatForm.textBox1.Text
                       };
                      // catbutton.FlatAppearance.BorderSize = 0;
                       catbutton.label1.Click += FiltrarCategoria;
                       catbutton.Paint += Catbutton_Paint;



                       //buscar si existe.
                       if (!parent.Controls.ContainsKey(catbutton.Name))
                       {
                           parent.Controls.Add(catbutton);
                       }
                       else
                       {
                           return;
                       }
                       

                       parent.Controls.SetChildIndex(control, zIndex + 1);

                       FiltrarCategoria(catbutton.label1, e);
                       NewCatForm.Close();
                   }
                   else
                   {
                       return;
                   }
               });
                NewCatForm.ShowDialog();
            }
           
            //mostrar boton de agregar.
            if(CategoryPanel.Controls.Count > 1)
            {
                AddIPButton.Visible = true;
                this.bt_ShowAll.Visible = true;
            }
        }

        //Filtrar Categoria
        private void FiltrarCategoria(object sender, EventArgs e)
        {
            this.AddIPButton.Visible = true;

            var boton = (Label)sender;

            ButtonPanel.Name = boton.Parent.Name;
            AddIPButton.Name = boton.Parent.Name;
            Titulo.Text = boton.Parent.Name;

            for (int i = 0; i < ButtonPanel.Controls.Count; i++)
            {
                if(ButtonPanel.Controls[i].GetType() == typeof(LineChart))
                {
                    var temp = (LineChart)ButtonPanel.Controls[i];
                    if (temp.tag != boton.Text)
                        temp.Visible = false;
                    else
                        temp.Visible = true;
                }
            }
        }

        //Mostrar Todo
        private void bt_ShowAll_Click(object sender, EventArgs e)
        {
            this.AddIPButton.Visible = false;
            this.Titulo.Text = "Todos los equipos";
            for (int i = 0; i < ButtonPanel.Controls.Count; i++)
            {
                if (ButtonPanel.Controls[i].GetType() == typeof(LineChart))
                {
                    var temp = (LineChart)ButtonPanel.Controls[i];
                    temp.Visible = true;
                }
            }
        }
        #endregion


        //Adicional
        private void Catbutton_Paint(object sender, PaintEventArgs e)
        {
            ((CategoryButton)sender).label1.Font = sizeTextToControl(((CategoryButton)sender).label1, e.Graphics, 10);
        }
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

        private void bt_Config_Click(object sender, EventArgs e)
        {
            using(var Config = new FormDiag_Config())
            {
                Config.txt_waitTime.textBox1.Text = this.waitTime.ToString();
                //Apply Config
                Config.bt_Apply.Click += new EventHandler(delegate (object obj, EventArgs args) 
                {
                    this.waitTime = int.Parse(Config.txt_waitTime.textBox1.Text);
                    foreach(LineChart chart in this.ButtonPanel.Controls.OfType<LineChart>())
                    {
                        chart.interval = waitTime;
                        chart.Reset();
                    }
                    Config.Dispose();
                });

                //Load File
                Config.bt_Load.Click += new EventHandler(delegate (object obj, EventArgs args)
                {
                    try
                    {
                        using (OpenFileDialog sv = new OpenFileDialog())
                        {
                            sv.Title = "Abrir Archivo";
                            sv.Filter = "Pyromorphite File (*.pyr)|*.pyr|All files (*.*)|*.*";
                            sv.CheckFileExists = true;
                            sv.CheckPathExists = true;
                            //save
                            sv.ShowDialog();
                            OwnFile = sv.FileName;
                            LoadFile(OwnFile);
                        }
                    }
                    catch { }
                    Config.Dispose();
                });

                //Save File (after finding if exist)
                Config.bt_save.Click += new EventHandler(delegate (object obj, EventArgs args)
                {
                    try
                    {
                        using (SaveFileDialog sv = new SaveFileDialog())
                        {
                            sv.Title = "Guardar Como...";
                            sv.Filter = "Pyromorphite File (*.pyr)|*.pyr|All files (*.*)|*.*";
                            sv.CheckFileExists = false;
                            sv.CheckPathExists = true;
                            sv.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            if (!File.Exists(OwnFile))
                            {
                                //save
                                sv.ShowDialog();
                                OwnFile = sv.FileName;
                                SaveFile(OwnFile);
                            }
                            else
                            {
                                SaveFile(OwnFile);
                            }
                        }
                    }
                    catch { }
                    Config.Dispose();
                });

                //Save like another File
                Config.bt_SaveLike.Click += new EventHandler(delegate (object obj, EventArgs args)
                {
                    try
                    {
                        using (SaveFileDialog sv = new SaveFileDialog())
                        {
                            sv.Title = "Guardar Como...";
                            sv.Filter = "Pyromorphite File (*.pyr)|*.pyr|All files (*.*)|*.*";
                            sv.CheckFileExists = false;
                            sv.CheckPathExists = true;
                            sv.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            //save
                            sv.ShowDialog();
                            OwnFile = sv.FileName;
                            SaveFile(OwnFile);
                        }
                    }
                    catch { }
                    Config.Dispose();
                });

                Config.ShowDialog();
            }
        }
    }
}
