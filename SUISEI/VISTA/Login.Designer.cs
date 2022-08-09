namespace SUISEI.VISTA
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codU = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.lklbl_contra = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.pic_cerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(112, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "SUISEI";
            // 
            // txt_codU
            // 
            this.txt_codU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codU.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codU.ForeColor = System.Drawing.Color.DimGray;
            this.txt_codU.Location = new System.Drawing.Point(50, 46);
            this.txt_codU.Name = "txt_codU";
            this.txt_codU.Size = new System.Drawing.Size(223, 17);
            this.txt_codU.TabIndex = 1;
            this.txt_codU.Text = "Código de Usuario";
            this.txt_codU.Enter += new System.EventHandler(this.txt_codU_Enter);
            this.txt_codU.Leave += new System.EventHandler(this.txt_codU_Leave);
            // 
            // txt_contra
            // 
            this.txt_contra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_contra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contra.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contra.ForeColor = System.Drawing.Color.DimGray;
            this.txt_contra.Location = new System.Drawing.Point(50, 78);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(223, 17);
            this.txt_contra.TabIndex = 2;
            this.txt_contra.Text = "Contraseña";
            this.txt_contra.Enter += new System.EventHandler(this.txt_contra_Enter);
            this.txt_contra.Leave += new System.EventHandler(this.txt_contra_Leave);
            // 
            // lklbl_contra
            // 
            this.lklbl_contra.ActiveLinkColor = System.Drawing.Color.Red;
            this.lklbl_contra.AutoSize = true;
            this.lklbl_contra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lklbl_contra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lklbl_contra.ForeColor = System.Drawing.Color.RosyBrown;
            this.lklbl_contra.LinkColor = System.Drawing.Color.RosyBrown;
            this.lklbl_contra.Location = new System.Drawing.Point(95, 175);
            this.lklbl_contra.Name = "lklbl_contra";
            this.lklbl_contra.Size = new System.Drawing.Size(131, 13);
            this.lklbl_contra.TabIndex = 0;
            this.lklbl_contra.TabStop = true;
            this.lklbl_contra.Text = "¿Olvidaste tu contraseña?";
            this.lklbl_contra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.btn_ingresar);
            this.panel1.Controls.Add(this.txt_codU);
            this.panel1.Controls.Add(this.lklbl_contra);
            this.panel1.Controls.Add(this.txt_contra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 246);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.btn_ingresar.Location = new System.Drawing.Point(72, 123);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(176, 40);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // pic_cerrar
            // 
            this.pic_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_cerrar.Image = global::SUISEI.Properties.Resources.cerrar;
            this.pic_cerrar.Location = new System.Drawing.Point(307, 0);
            this.pic_cerrar.Name = "pic_cerrar";
            this.pic_cerrar.Size = new System.Drawing.Size(12, 12);
            this.pic_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cerrar.TabIndex = 10;
            this.pic_cerrar.TabStop = false;
            this.pic_cerrar.Click += new System.EventHandler(this.pic_cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBox1.Image = global::SUISEI.Properties.Resources.logoSuiseiBlanco;
            this.pictureBox1.Location = new System.Drawing.Point(72, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(319, 474);
            this.Controls.Add(this.pic_cerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codU;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.LinkLabel lklbl_contra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.PictureBox pic_cerrar;
    }
}