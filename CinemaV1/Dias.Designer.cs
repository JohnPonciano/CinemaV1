namespace CinemaV1
{
    partial class Dias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dias));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TagIdade = new System.Windows.Forms.Label();
            this.label1genero = new System.Windows.Forms.Label();
            this.label2genero = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.labelSinopseTitulo = new System.Windows.Forms.Label();
            this.labelTextpSinopse = new System.Windows.Forms.Label();
            this.Data1 = new System.Windows.Forms.Button();
            this.Data2 = new System.Windows.Forms.Button();
            this.checkBox2D = new System.Windows.Forms.CheckBox();
            this.checkBoxDub = new System.Windows.Forms.CheckBox();
            this.checkBox3D = new System.Windows.Forms.CheckBox();
            this.checkBoxLeg = new System.Windows.Forms.CheckBox();
            this.Bannerhorario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bannerhorario)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(815, 354);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(528, 279);
            this.webBrowser1.TabIndex = 19;
            this.webBrowser1.Url = new System.Uri("https://www.youtube.com/embed/MsQNB5hYvFc?&controls=1&autoplay=1&allowsInlineMedi" +
        "aPlayback=1", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // TagIdade
            // 
            this.TagIdade.AutoSize = true;
            this.TagIdade.BackColor = System.Drawing.Color.Transparent;
            this.TagIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TagIdade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TagIdade.ForeColor = System.Drawing.Color.Yellow;
            this.TagIdade.Location = new System.Drawing.Point(308, 23);
            this.TagIdade.Name = "TagIdade";
            this.TagIdade.Size = new System.Drawing.Size(47, 15);
            this.TagIdade.TabIndex = 1;
            this.TagIdade.Text = "12 anos";
            // 
            // label1genero
            // 
            this.label1genero.AutoSize = true;
            this.label1genero.BackColor = System.Drawing.Color.Transparent;
            this.label1genero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1genero.ForeColor = System.Drawing.Color.White;
            this.label1genero.Location = new System.Drawing.Point(363, 60);
            this.label1genero.Name = "label1genero";
            this.label1genero.Size = new System.Drawing.Size(34, 15);
            this.label1genero.TabIndex = 2;
            this.label1genero.Text = "Ação";
            // 
            // label2genero
            // 
            this.label2genero.AutoSize = true;
            this.label2genero.BackColor = System.Drawing.Color.Transparent;
            this.label2genero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2genero.ForeColor = System.Drawing.Color.White;
            this.label2genero.Location = new System.Drawing.Point(308, 60);
            this.label2genero.Name = "label2genero";
            this.label2genero.Size = new System.Drawing.Size(49, 15);
            this.label2genero.TabIndex = 3;
            this.label2genero.Text = "Fantasia";
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(1312, 11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(31, 27);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // labelSinopseTitulo
            // 
            this.labelSinopseTitulo.AutoSize = true;
            this.labelSinopseTitulo.Location = new System.Drawing.Point(312, 105);
            this.labelSinopseTitulo.Name = "labelSinopseTitulo";
            this.labelSinopseTitulo.Size = new System.Drawing.Size(45, 13);
            this.labelSinopseTitulo.TabIndex = 11;
            this.labelSinopseTitulo.Text = "Sinopse";
            // 
            // labelTextpSinopse
            // 
            this.labelTextpSinopse.Location = new System.Drawing.Point(312, 139);
            this.labelTextpSinopse.Name = "labelTextpSinopse";
            this.labelTextpSinopse.Size = new System.Drawing.Size(534, 340);
            this.labelTextpSinopse.TabIndex = 12;
            this.labelTextpSinopse.Text = resources.GetString("labelTextpSinopse.Text");
            this.labelTextpSinopse.UseMnemonic = false;
            // 
            // Data1
            // 
            this.Data1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Data1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Data1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Data1.Location = new System.Drawing.Point(27, 480);
            this.Data1.Name = "Data1";
            this.Data1.Size = new System.Drawing.Size(105, 83);
            this.Data1.TabIndex = 13;
            this.Data1.Text = "BtnDataHoje";
            this.Data1.UseVisualStyleBackColor = false;
            this.Data1.Click += new System.EventHandler(this.Data1_Click);
            // 
            // Data2
            // 
            this.Data2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Data2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Data2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.Data2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Data2.Location = new System.Drawing.Point(164, 480);
            this.Data2.Name = "Data2";
            this.Data2.Size = new System.Drawing.Size(109, 83);
            this.Data2.TabIndex = 14;
            this.Data2.Text = "BtnDataHoje2";
            this.Data2.UseVisualStyleBackColor = false;
            this.Data2.Click += new System.EventHandler(this.Data2_Click);
            // 
            // checkBox2D
            // 
            this.checkBox2D.AutoSize = true;
            this.checkBox2D.Location = new System.Drawing.Point(321, 365);
            this.checkBox2D.Name = "checkBox2D";
            this.checkBox2D.Size = new System.Drawing.Size(40, 17);
            this.checkBox2D.TabIndex = 15;
            this.checkBox2D.Text = "2D";
            this.checkBox2D.UseVisualStyleBackColor = true;
            // 
            // checkBoxDub
            // 
            this.checkBoxDub.AutoSize = true;
            this.checkBoxDub.Location = new System.Drawing.Point(432, 365);
            this.checkBoxDub.Name = "checkBoxDub";
            this.checkBoxDub.Size = new System.Drawing.Size(46, 17);
            this.checkBoxDub.TabIndex = 16;
            this.checkBoxDub.Text = "Dub";
            this.checkBoxDub.UseVisualStyleBackColor = true;
            // 
            // checkBox3D
            // 
            this.checkBox3D.AutoSize = true;
            this.checkBox3D.Location = new System.Drawing.Point(321, 411);
            this.checkBox3D.Name = "checkBox3D";
            this.checkBox3D.Size = new System.Drawing.Size(40, 17);
            this.checkBox3D.TabIndex = 17;
            this.checkBox3D.Text = "3D";
            this.checkBox3D.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeg
            // 
            this.checkBoxLeg.AutoSize = true;
            this.checkBoxLeg.Location = new System.Drawing.Point(432, 411);
            this.checkBoxLeg.Name = "checkBoxLeg";
            this.checkBoxLeg.Size = new System.Drawing.Size(44, 17);
            this.checkBoxLeg.TabIndex = 18;
            this.checkBoxLeg.Text = "Leg";
            this.checkBoxLeg.UseVisualStyleBackColor = true;
            // 
            // Bannerhorario
            // 
            this.Bannerhorario.Image = global::CinemaV1.Properties.Resources.Shazam;
            this.Bannerhorario.Location = new System.Drawing.Point(12, 12);
            this.Bannerhorario.Name = "Bannerhorario";
            this.Bannerhorario.Size = new System.Drawing.Size(275, 417);
            this.Bannerhorario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bannerhorario.TabIndex = 0;
            this.Bannerhorario.TabStop = false;
            // 
            // Dias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1356, 651);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.checkBoxLeg);
            this.Controls.Add(this.checkBox3D);
            this.Controls.Add(this.checkBoxDub);
            this.Controls.Add(this.checkBox2D);
            this.Controls.Add(this.Data2);
            this.Controls.Add(this.Data1);
            this.Controls.Add(this.labelTextpSinopse);
            this.Controls.Add(this.labelSinopseTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label2genero);
            this.Controls.Add(this.label1genero);
            this.Controls.Add(this.TagIdade);
            this.Controls.Add(this.Bannerhorario);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HorarioCaptan";
            ((System.ComponentModel.ISupportInitialize)(this.Bannerhorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bannerhorario;
        private System.Windows.Forms.Label TagIdade;
        private System.Windows.Forms.Label label1genero;
        private System.Windows.Forms.Label label2genero;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label labelSinopseTitulo;
        private System.Windows.Forms.Label labelTextpSinopse;
        private System.Windows.Forms.Button Data1;
        private System.Windows.Forms.Button Data2;
        private System.Windows.Forms.CheckBox checkBox2D;
        private System.Windows.Forms.CheckBox checkBoxDub;
        private System.Windows.Forms.CheckBox checkBox3D;
        private System.Windows.Forms.CheckBox checkBoxLeg;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}