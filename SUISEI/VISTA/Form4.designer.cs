namespace SUISEI
{
    partial class Rcontra2
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
            this.txtPrecu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNcontra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNcontra2 = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.btnGuardarContra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabra secreta";
            // 
            // txtPrecu
            // 
            this.txtPrecu.Location = new System.Drawing.Point(12, 204);
            this.txtPrecu.Name = "txtPrecu";
            this.txtPrecu.Size = new System.Drawing.Size(185, 20);
            this.txtPrecu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nueva Contraseña";
            // 
            // txtNcontra
            // 
            this.txtNcontra.Enabled = false;
            this.txtNcontra.Location = new System.Drawing.Point(12, 293);
            this.txtNcontra.Name = "txtNcontra";
            this.txtNcontra.Size = new System.Drawing.Size(185, 20);
            this.txtNcontra.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // txtNcontra2
            // 
            this.txtNcontra2.Enabled = false;
            this.txtNcontra2.Location = new System.Drawing.Point(12, 343);
            this.txtNcontra2.Name = "txtNcontra2";
            this.txtNcontra2.Size = new System.Drawing.Size(185, 20);
            this.txtNcontra2.TabIndex = 6;
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Location = new System.Drawing.Point(12, 227);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(16, 13);
            this.txtError.TabIndex = 9;
            this.txtError.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OldLace;
            this.pictureBox1.Image = global::SUISEI.Properties.Resources.logoSuisei;
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnComprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobar.FlatAppearance.BorderSize = 0;
            this.btnComprobar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnComprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobar.ForeColor = System.Drawing.Color.OldLace;
            this.btnComprobar.Location = new System.Drawing.Point(60, 240);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(75, 23);
            this.btnComprobar.TabIndex = 10;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnGuardarContra
            // 
            this.btnGuardarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardarContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarContra.Enabled = false;
            this.btnGuardarContra.FlatAppearance.BorderSize = 0;
            this.btnGuardarContra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGuardarContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarContra.ForeColor = System.Drawing.Color.OldLace;
            this.btnGuardarContra.Location = new System.Drawing.Point(60, 373);
            this.btnGuardarContra.Name = "btnGuardarContra";
            this.btnGuardarContra.Size = new System.Drawing.Size(80, 23);
            this.btnGuardarContra.TabIndex = 11;
            this.btnGuardarContra.Text = "Guardar";
            this.btnGuardarContra.UseVisualStyleBackColor = false;
            this.btnGuardarContra.Click += new System.EventHandler(this.btnGuardarContra_Click);
            // 
            // Rcontra2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(209, 424);
            this.Controls.Add(this.btnGuardarContra);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNcontra2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNcontra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecu);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rcontra2";
            this.Text = "Restablecer contraseña";
            this.Load += new System.EventHandler(this.Rcontra2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNcontra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNcontra2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Button btnGuardarContra;
    }
}