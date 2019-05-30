namespace CinemaV1
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.btnSair = new System.Windows.Forms.Button();
            this.Slideimg = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeltitulo = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnLogado = new System.Windows.Forms.Button();
            this.Box3 = new System.Windows.Forms.PictureBox();
            this.Box2 = new System.Windows.Forms.PictureBox();
            this.Box1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Slideimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(1281, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(44, 37);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Exit";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // Slideimg
            // 
            this.Slideimg.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Slideimg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Slideimg.Enabled = false;
            this.Slideimg.ErrorImage = null;
            this.Slideimg.InitialImage = null;
            this.Slideimg.Location = new System.Drawing.Point(0, 51);
            this.Slideimg.Name = "Slideimg";
            this.Slideimg.Size = new System.Drawing.Size(1332, 701);
            this.Slideimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slideimg.TabIndex = 11;
            this.Slideimg.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.BackColor = System.Drawing.Color.Transparent;
            this.labeltitulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labeltitulo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.ForeColor = System.Drawing.Color.Cyan;
            this.labeltitulo.Location = new System.Drawing.Point(552, 9);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(179, 40);
            this.labeltitulo.TabIndex = 15;
            this.labeltitulo.Text = "Em Cartaz";
            // 
            // lbl1
            // 
            this.lbl1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Arial", 24F);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(998, 557);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(181, 72);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "Vingadores \r\n  Ultimato";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl2.Font = new System.Drawing.Font("Arial", 24F);
            this.lbl2.ForeColor = System.Drawing.Color.Aqua;
            this.lbl2.Location = new System.Drawing.Point(203, 573);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(141, 36);
            this.lbl2.TabIndex = 20;
            this.lbl2.Text = "Shazam!";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(586, 573);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(208, 36);
            this.lbl3.TabIndex = 21;
            this.lbl3.Text = "Capitã Marvel";
            // 
            // btnLogado
            // 
            this.btnLogado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogado.ForeColor = System.Drawing.Color.Cyan;
            this.btnLogado.Location = new System.Drawing.Point(1119, 16);
            this.btnLogado.Name = "btnLogado";
            this.btnLogado.Size = new System.Drawing.Size(135, 29);
            this.btnLogado.TabIndex = 22;
            this.btnLogado.Text = "logado";
            this.btnLogado.UseVisualStyleBackColor = true;
            this.btnLogado.Click += new System.EventHandler(this.btnLogado_Click);
            // 
            // Box3
            // 
            this.Box3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Box3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Box3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box3.Image = global::CinemaV1.Properties.Resources.vingadores_ultimato_poster;
            this.Box3.Location = new System.Drawing.Point(961, 181);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(254, 402);
            this.Box3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box3.TabIndex = 10;
            this.Box3.TabStop = false;
            this.Box3.Click += new System.EventHandler(this.Box3_Click);
            // 
            // Box2
            // 
            this.Box2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Box2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Box2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box2.Image = global::CinemaV1.Properties.Resources.Shazam;
            this.Box2.Location = new System.Drawing.Point(154, 181);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(254, 402);
            this.Box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box2.TabIndex = 9;
            this.Box2.TabStop = false;
            this.Box2.Click += new System.EventHandler(this.Shazam_Click);
            // 
            // Box1
            // 
            this.Box1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Box1.BackColor = System.Drawing.Color.Cyan;
            this.Box1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Box1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box1.Image = global::CinemaV1.Properties.Resources._0230901_jpg_r_1280_720_f_jpg_q_x_xxyxx;
            this.Box1.Location = new System.Drawing.Point(559, 181);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(256, 402);
            this.Box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box1.TabIndex = 0;
            this.Box1.TabStop = false;
            this.Box1.Click += new System.EventHandler(this.Box1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1337, 777);
            this.Controls.Add(this.btnLogado);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.Slideimg);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.Slideimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox Box2;
        private System.Windows.Forms.PictureBox Box3;
        private System.Windows.Forms.PictureBox Slideimg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnLogado;
    }
}