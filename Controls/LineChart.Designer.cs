
namespace Pyromorphite.Controls
{
    partial class LineChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.Label();
            this.bt_Edit = new Pyromorphite.Controls.Item.MButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new Pyromorphite.Controls.Item.Chart();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.nombre.Font = new System.Drawing.Font("Stencil", 15.75F);
            this.nombre.ForeColor = System.Drawing.Color.PaleGreen;
            this.nombre.Location = new System.Drawing.Point(1, 1);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(197, 27);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ip
            // 
            this.txt_ip.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_ip.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ip.ForeColor = System.Drawing.Color.LimeGreen;
            this.txt_ip.Location = new System.Drawing.Point(1, 28);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(197, 27);
            this.txt_ip.TabIndex = 1;
            this.txt_ip.Text = "0.0.0.0";
            this.txt_ip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Edit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Edit.FlatAppearance.BorderSize = 0;
            this.bt_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Edit.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Edit.Location = new System.Drawing.Point(1, 162);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(197, 24);
            this.bt_Edit.TabIndex = 3;
            this.bt_Edit.TabStop = false;
            this.bt_Edit.Text = "Editar";
            this.bt_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 107);
            this.panel1.TabIndex = 4;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(197, 107);
            this.chart1.TabIndex = 0;
            // 
            // LineChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.nombre);
            this.Name = "LineChart";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(199, 187);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label nombre;
        public System.Windows.Forms.Label txt_ip;
        private Pyromorphite.Controls.Item.MButton bt_Edit;
        private System.Windows.Forms.Panel panel1;
        private Item.Chart chart1;
    }
}
