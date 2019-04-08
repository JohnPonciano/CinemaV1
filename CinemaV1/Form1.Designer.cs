namespace CinemaV1
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtBoxUser = new System.Windows.Forms.TextBox();
            this.TxtBoxPass = new System.Windows.Forms.TextBox();
            this.btnloginmain = new System.Windows.Forms.Button();
            this.btncadastromain = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(68, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(69, 356);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // TxtBoxUser
            // 
            this.TxtBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxUser.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxUser.ForeColor = System.Drawing.Color.White;
            this.TxtBoxUser.Location = new System.Drawing.Point(113, 283);
            this.TxtBoxUser.Name = "TxtBoxUser";
            this.TxtBoxUser.Size = new System.Drawing.Size(171, 20);
            this.TxtBoxUser.TabIndex = 3;
            this.TxtBoxUser.Text = "User";
            // 
            // TxtBoxPass
            // 
            this.TxtBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxPass.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPass.ForeColor = System.Drawing.Color.White;
            this.TxtBoxPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtBoxPass.Location = new System.Drawing.Point(113, 365);
            this.TxtBoxPass.Name = "TxtBoxPass";
            this.TxtBoxPass.PasswordChar = '*';
            this.TxtBoxPass.Size = new System.Drawing.Size(171, 20);
            this.TxtBoxPass.TabIndex = 4;
            this.TxtBoxPass.Text = "Password";
            // 
            // btnloginmain
            // 
            this.btnloginmain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnloginmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloginmain.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloginmain.ForeColor = System.Drawing.Color.White;
            this.btnloginmain.Location = new System.Drawing.Point(69, 435);
            this.btnloginmain.Name = "btnloginmain";
            this.btnloginmain.Size = new System.Drawing.Size(215, 52);
            this.btnloginmain.TabIndex = 5;
            this.btnloginmain.Text = "Login";
            this.btnloginmain.UseVisualStyleBackColor = true;
            this.btnloginmain.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btncadastromain
            // 
            this.btncadastromain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadastromain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastromain.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastromain.ForeColor = System.Drawing.Color.White;
            this.btncadastromain.Location = new System.Drawing.Point(128, 562);
            this.btncadastromain.Name = "btncadastromain";
            this.btncadastromain.Size = new System.Drawing.Size(100, 54);
            this.btncadastromain.TabIndex = 6;
            this.btncadastromain.Text = "Cadastrar";
            this.btncadastromain.UseVisualStyleBackColor = true;
            this.btncadastromain.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(303, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(44, 37);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Exit";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(359, 659);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btncadastromain);
            this.Controls.Add(this.btnloginmain);
            this.Controls.Add(this.TxtBoxPass);
            this.Controls.Add(this.TxtBoxUser);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtBoxUser;
        private System.Windows.Forms.TextBox TxtBoxPass;
        private System.Windows.Forms.Button btnloginmain;
        private System.Windows.Forms.Button btncadastromain;
        private System.Windows.Forms.Button btnSair;
    }
}

