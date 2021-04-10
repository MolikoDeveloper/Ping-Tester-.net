
namespace Pyromorphite
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddIPButton = new Pyromorphite.Controls.Item.MButton();
            this.bt_minimize = new Pyromorphite.Controls.Item.MButton();
            this.bt_Close = new Pyromorphite.Controls.Item.MButton();
            this.Left_Button_add = new Pyromorphite.Controls.Item.MButton();
            this.bt_Config = new Pyromorphite.Controls.Item.MButton();
            this.bt_ShowAll = new Pyromorphite.Controls.Item.MButton();
            this.panel1.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CategoryPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 681);
            this.panel1.TabIndex = 0;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.AutoScroll = true;
            this.CategoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoryPanel.Controls.Add(this.Left_Button_add);
            this.CategoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryPanel.Location = new System.Drawing.Point(0, 82);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(213, 554);
            this.CategoryPanel.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 82);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousedown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pyromorphite.Properties.Resources.IP_STATUS_ICO;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousedown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP STATUS\r\nBy: Albert_AC";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousedown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.bt_Config);
            this.panel4.Controls.Add(this.bt_ShowAll);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 636);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 43);
            this.panel4.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.bt_minimize);
            this.panel2.Controls.Add(this.Titulo);
            this.panel2.Controls.Add(this.bt_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(215, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 30);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDoubleClick);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousedown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // Titulo
            // 
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(6, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(672, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Ubicación";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDoubleClick);
            this.Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousedown);
            this.Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.Titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.AutoScroll = true;
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.AddIPButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(215, 30);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(760, 651);
            this.ButtonPanel.TabIndex = 99;
            // 
            // AddIPButton
            // 
            this.AddIPButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.AddIPButton.BackgroundImage = global::Pyromorphite.Properties.Resources.plus;
            this.AddIPButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddIPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddIPButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.AddIPButton.FlatAppearance.BorderSize = 0;
            this.AddIPButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddIPButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.AddIPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIPButton.Location = new System.Drawing.Point(10, 65);
            this.AddIPButton.Margin = new System.Windows.Forms.Padding(10, 65, 10, 10);
            this.AddIPButton.Name = "AddIPButton";
            this.AddIPButton.Size = new System.Drawing.Size(70, 70);
            this.AddIPButton.TabIndex = 0;
            this.AddIPButton.TabStop = false;
            this.AddIPButton.UseVisualStyleBackColor = false;
            this.AddIPButton.Visible = false;
            this.AddIPButton.Click += new System.EventHandler(this.AddChartIP);
            // 
            // bt_minimize
            // 
            this.bt_minimize.BackColor = System.Drawing.Color.Transparent;
            this.bt_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_minimize.FlatAppearance.BorderSize = 0;
            this.bt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimize.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minimize.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_minimize.Location = new System.Drawing.Point(700, 0);
            this.bt_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.bt_minimize.MaximumSize = new System.Drawing.Size(30, 32);
            this.bt_minimize.MinimumSize = new System.Drawing.Size(20, 30);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.bt_minimize.Size = new System.Drawing.Size(30, 30);
            this.bt_minimize.TabIndex = 0;
            this.bt_minimize.TabStop = false;
            this.bt_minimize.Text = "-";
            this.bt_minimize.UseVisualStyleBackColor = false;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.BackColor = System.Drawing.Color.Transparent;
            this.bt_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Close.FlatAppearance.BorderSize = 0;
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Close.Location = new System.Drawing.Point(730, 0);
            this.bt_Close.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Close.MaximumSize = new System.Drawing.Size(30, 32);
            this.bt_Close.MinimumSize = new System.Drawing.Size(30, 30);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bt_Close.Size = new System.Drawing.Size(30, 30);
            this.bt_Close.TabIndex = 0;
            this.bt_Close.TabStop = false;
            this.bt_Close.Text = "X";
            this.bt_Close.UseVisualStyleBackColor = false;
            this.bt_Close.Click += new System.EventHandler(this.CloseApp);
            // 
            // Left_Button_add
            // 
            this.Left_Button_add.AllowDrop = true;
            this.Left_Button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.Left_Button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Left_Button_add.CausesValidation = false;
            this.Left_Button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Left_Button_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.Left_Button_add.FlatAppearance.BorderSize = 0;
            this.Left_Button_add.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.Left_Button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.Left_Button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.Left_Button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left_Button_add.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left_Button_add.ForeColor = System.Drawing.SystemColors.Control;
            this.Left_Button_add.Image = global::Pyromorphite.Properties.Resources.plus_tiny;
            this.Left_Button_add.Location = new System.Drawing.Point(3, 3);
            this.Left_Button_add.Name = "Left_Button_add";
            this.Left_Button_add.Size = new System.Drawing.Size(192, 43);
            this.Left_Button_add.TabIndex = 0;
            this.Left_Button_add.TabStop = false;
            this.Left_Button_add.Text = "Agregar categoría";
            this.Left_Button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Left_Button_add.UseVisualStyleBackColor = false;
            this.Left_Button_add.Click += new System.EventHandler(this.AddCategory);
            // 
            // bt_Config
            // 
            this.bt_Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.bt_Config.BackgroundImage = global::Pyromorphite.Properties.Resources.config11;
            this.bt_Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Config.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Config.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Config.FlatAppearance.BorderSize = 0;
            this.bt_Config.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Config.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Config.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Config.Location = new System.Drawing.Point(0, 0);
            this.bt_Config.MaximumSize = new System.Drawing.Size(43, 43);
            this.bt_Config.Name = "bt_Config";
            this.bt_Config.Size = new System.Drawing.Size(39, 41);
            this.bt_Config.TabIndex = 1;
            this.bt_Config.TabStop = false;
            this.bt_Config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Config.UseVisualStyleBackColor = false;
            this.bt_Config.Click += new System.EventHandler(this.bt_Config_Click);
            // 
            // bt_ShowAll
            // 
            this.bt_ShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_ShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_ShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ShowAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_ShowAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_ShowAll.FlatAppearance.BorderSize = 0;
            this.bt_ShowAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_ShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_ShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ShowAll.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ShowAll.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_ShowAll.Location = new System.Drawing.Point(39, 0);
            this.bt_ShowAll.Name = "bt_ShowAll";
            this.bt_ShowAll.Size = new System.Drawing.Size(172, 41);
            this.bt_ShowAll.TabIndex = 0;
            this.bt_ShowAll.TabStop = false;
            this.bt_ShowAll.Text = "Mostrar Todos";
            this.bt_ShowAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ShowAll.UseVisualStyleBackColor = false;
            this.bt_ShowAll.Visible = false;
            this.bt_ShowAll.Click += new System.EventHandler(this.bt_ShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 681);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pyromorphite";
            this.panel1.ResumeLayout(false);
            this.CategoryPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titulo;
        private Pyromorphite.Controls.Item.MButton bt_Close;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private Pyromorphite.Controls.Item.MButton Left_Button_add;
        private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
        private Pyromorphite.Controls.Item.MButton AddIPButton;
        private Pyromorphite.Controls.Item.MButton bt_minimize;
        private Pyromorphite.Controls.Item.MButton bt_ShowAll;
        private System.Windows.Forms.Panel panel4;
        private Pyromorphite.Controls.Item.MButton bt_Config;
    }
}

