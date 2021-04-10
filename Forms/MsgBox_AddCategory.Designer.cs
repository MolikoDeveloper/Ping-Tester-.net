
namespace Pyromorphite.Forms
{
    partial class MsgBox_AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox_AddCategory));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Confirm = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new Pyromorphite.Controls.MtextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la categoria:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousedown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // bt_Confirm
            // 
            this.bt_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Confirm.FlatAppearance.BorderSize = 0;
            this.bt_Confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Confirm.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Confirm.Location = new System.Drawing.Point(12, 65);
            this.bt_Confirm.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.bt_Confirm.Name = "bt_Confirm";
            this.bt_Confirm.Size = new System.Drawing.Size(241, 43);
            this.bt_Confirm.TabIndex = 1;
            this.bt_Confirm.TabStop = false;
            this.bt_Confirm.Text = "Crear Categoría";
            this.bt_Confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Confirm.UseVisualStyleBackColor = false;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.FlatAppearance.BorderSize = 0;
            this.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cancel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Cancel.Location = new System.Drawing.Point(76, 118);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(120, 33);
            this.bt_Cancel.TabIndex = 2;
            this.bt_Cancel.TabStop = false;
            this.bt_Cancel.Text = "Cancelar";
            this.bt_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_Cancel);
            this.panel1.Controls.Add(this.bt_Confirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 165);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousedown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.MaximumSize = new System.Drawing.Size(1000, 32);
            this.textBox1.MinimumSize = new System.Drawing.Size(200, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MsgBox_AddCategory
            // 
            this.AcceptButton = this.bt_Confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CancelButton = this.bt_Cancel;
            this.ClientSize = new System.Drawing.Size(265, 165);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MsgBox_AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgBox_AddCategory";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousedown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bt_Confirm;
        public System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Panel panel1;
        public Controls.MtextBox textBox1;
    }
}