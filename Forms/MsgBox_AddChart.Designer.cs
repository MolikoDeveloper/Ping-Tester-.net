
namespace Pyromorphite.Forms
{
    partial class MsgBox_AddChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox_AddChart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ip = new Pyromorphite.Controls.MtextBox();
            this.txt_name = new Pyromorphite.Controls.MtextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Confirm = new System.Windows.Forms.Button();
            this.mtextBox1 = new Pyromorphite.Controls.MtextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_ip);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_Cancel);
            this.panel1.Controls.Add(this.bt_Confirm);
            this.panel1.Controls.Add(this.mtextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 218);
            this.panel1.TabIndex = 0;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(12, 88);
            this.txt_ip.MaximumSize = new System.Drawing.Size(1000, 32);
            this.txt_ip.MinimumSize = new System.Drawing.Size(200, 32);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(240, 32);
            this.txt_ip.TabIndex = 9;
            this.txt_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 32);
            this.txt_name.MaximumSize = new System.Drawing.Size(1000, 32);
            this.txt_name.MinimumSize = new System.Drawing.Size(200, 32);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(240, 32);
            this.txt_name.TabIndex = 8;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dirección ip o url:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.bt_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.FlatAppearance.BorderSize = 0;
            this.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cancel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Cancel.Location = new System.Drawing.Point(71, 173);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(120, 33);
            this.bt_Cancel.TabIndex = 3;
            this.bt_Cancel.TabStop = false;
            this.bt_Cancel.Text = "Cancelar";
            this.bt_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Cancel.UseVisualStyleBackColor = false;
            // 
            // bt_Confirm
            // 
            this.bt_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.bt_Confirm.Location = new System.Drawing.Point(12, 124);
            this.bt_Confirm.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.bt_Confirm.Name = "bt_Confirm";
            this.bt_Confirm.Size = new System.Drawing.Size(241, 43);
            this.bt_Confirm.TabIndex = 2;
            this.bt_Confirm.TabStop = false;
            this.bt_Confirm.Text = "agregar";
            this.bt_Confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Confirm.UseVisualStyleBackColor = false;
            // 
            // mtextBox1
            // 
            this.mtextBox1.Enabled = false;
            this.mtextBox1.Location = new System.Drawing.Point(12, 144);
            this.mtextBox1.MaximumSize = new System.Drawing.Size(1000, 32);
            this.mtextBox1.MinimumSize = new System.Drawing.Size(200, 32);
            this.mtextBox1.Name = "mtextBox1";
            this.mtextBox1.Size = new System.Drawing.Size(240, 32);
            this.mtextBox1.TabIndex = 11;
            this.mtextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtextBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Puerto:";
            this.label2.Visible = false;
            // 
            // MsgBox_AddChart
            // 
            this.AcceptButton = this.bt_Confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CancelButton = this.bt_Cancel;
            this.ClientSize = new System.Drawing.Size(265, 218);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(265, 218);
            this.Name = "MsgBox_AddChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Dirección";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bt_Cancel;
        public System.Windows.Forms.Button bt_Confirm;
        public System.Windows.Forms.Panel panel1;
        public Controls.MtextBox txt_name;
        public Controls.MtextBox txt_ip;
        public Controls.MtextBox mtextBox1;
        private System.Windows.Forms.Label label2;
    }
}