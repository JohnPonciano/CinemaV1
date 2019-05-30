namespace CinemaV1
{
    partial class adminlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminlogin));
            this.textsinopse = new System.Windows.Forms.TextBox();
            this.comboTagidade = new System.Windows.Forms.ComboBox();
            this.imgload = new System.Windows.Forms.PictureBox();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.BtnUploadAll = new System.Windows.Forms.Button();
            this.textNavegacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBTNbox1 = new System.Windows.Forms.RadioButton();
            this.radioBTNbox2 = new System.Windows.Forms.RadioButton();
            this.radioBTNbox3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomeDoFilme = new System.Windows.Forms.TextBox();
            this.checkedListGen = new System.Windows.Forms.CheckedListBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgload)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textsinopse
            // 
<<<<<<< HEAD
            this.textsinopse.BackColor = System.Drawing.Color.White;
            this.textsinopse.Location = new System.Drawing.Point(39, 96);
=======
            this.textsinopse.Location = new System.Drawing.Point(39, 315);
>>>>>>> 06ff7e5b3077362c29c9341aadafde5dbd7f917a
            this.textsinopse.Multiline = true;
            this.textsinopse.Name = "textsinopse";
            this.textsinopse.Size = new System.Drawing.Size(345, 129);
            this.textsinopse.TabIndex = 0;
            this.textsinopse.Text = "Digite a Sinopse aqui";
            // 
            // comboTagidade
            // 
            this.comboTagidade.BackColor = System.Drawing.Color.White;
            this.comboTagidade.Cursor = System.Windows.Forms.Cursors.No;
            this.comboTagidade.ForeColor = System.Drawing.Color.Black;
            this.comboTagidade.FormattingEnabled = true;
            this.comboTagidade.Items.AddRange(new object[] {
            "10",
            "12",
            "16",
            "18"});
            this.comboTagidade.Location = new System.Drawing.Point(30, 35);
            this.comboTagidade.Name = "comboTagidade";
            this.comboTagidade.Size = new System.Drawing.Size(121, 21);
            this.comboTagidade.TabIndex = 1;
            this.comboTagidade.Text = "Tag de Idade";
            // 
            // imgload
            // 
            this.imgload.BackColor = System.Drawing.Color.Transparent;
            this.imgload.Location = new System.Drawing.Point(433, 96);
            this.imgload.Name = "imgload";
            this.imgload.Size = new System.Drawing.Size(218, 348);
            this.imgload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgload.TabIndex = 2;
            this.imgload.TabStop = false;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.BackColor = System.Drawing.Color.White;
            this.btnLoadImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImg.Location = new System.Drawing.Point(709, 333);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(271, 59);
            this.btnLoadImg.TabIndex = 3;
            this.btnLoadImg.Text = "Carregar imagem";
            this.btnLoadImg.UseVisualStyleBackColor = false;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // BtnUploadAll
            // 
            this.BtnUploadAll.BackColor = System.Drawing.Color.White;
            this.BtnUploadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUploadAll.Location = new System.Drawing.Point(759, 398);
            this.BtnUploadAll.Name = "BtnUploadAll";
            this.BtnUploadAll.Size = new System.Drawing.Size(176, 67);
            this.BtnUploadAll.TabIndex = 4;
            this.BtnUploadAll.Text = "Upload";
            this.BtnUploadAll.UseVisualStyleBackColor = false;
            this.BtnUploadAll.Click += new System.EventHandler(this.BtnUploadAll_Click);
            // 
            // textNavegacao
            // 
            this.textNavegacao.BackColor = System.Drawing.Color.White;
            this.textNavegacao.Location = new System.Drawing.Point(199, 36);
            this.textNavegacao.Name = "textNavegacao";
            this.textNavegacao.Size = new System.Drawing.Size(452, 20);
            this.textNavegacao.TabIndex = 5;
            this.textNavegacao.Text = "Coloque aqui a URL, MAS LEMBRE TEM QUE SER UM LINK COM <EMBED>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Generos";
            // 
            // radioBTNbox1
            // 
            this.radioBTNbox1.AutoSize = true;
            this.radioBTNbox1.ForeColor = System.Drawing.Color.Black;
            this.radioBTNbox1.Location = new System.Drawing.Point(12, 43);
            this.radioBTNbox1.Name = "radioBTNbox1";
            this.radioBTNbox1.Size = new System.Drawing.Size(49, 17);
            this.radioBTNbox1.TabIndex = 8;
            this.radioBTNbox1.TabStop = true;
            this.radioBTNbox1.Text = "Box1";
            this.radioBTNbox1.UseVisualStyleBackColor = true;
            this.radioBTNbox1.CheckedChanged += new System.EventHandler(this.radioBTNbox1_CheckedChanged);
            // 
            // radioBTNbox2
            // 
            this.radioBTNbox2.AutoSize = true;
            this.radioBTNbox2.BackColor = System.Drawing.Color.Transparent;
            this.radioBTNbox2.Location = new System.Drawing.Point(67, 43);
            this.radioBTNbox2.Name = "radioBTNbox2";
            this.radioBTNbox2.Size = new System.Drawing.Size(49, 17);
            this.radioBTNbox2.TabIndex = 9;
            this.radioBTNbox2.TabStop = true;
            this.radioBTNbox2.Text = "Box2";
            this.radioBTNbox2.UseVisualStyleBackColor = false;
            this.radioBTNbox2.CheckedChanged += new System.EventHandler(this.radioBTNbox2_CheckedChanged);
            // 
            // radioBTNbox3
            // 
            this.radioBTNbox3.AutoSize = true;
            this.radioBTNbox3.Location = new System.Drawing.Point(122, 43);
            this.radioBTNbox3.Name = "radioBTNbox3";
            this.radioBTNbox3.Size = new System.Drawing.Size(49, 17);
            this.radioBTNbox3.TabIndex = 10;
            this.radioBTNbox3.TabStop = true;
            this.radioBTNbox3.Text = "Box3";
            this.radioBTNbox3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
<<<<<<< HEAD
            this.groupBox1.BackColor = System.Drawing.Color.White;
=======
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
>>>>>>> 06ff7e5b3077362c29c9341aadafde5dbd7f917a
            this.groupBox1.Controls.Add(this.radioBTNbox3);
            this.groupBox1.Controls.Add(this.radioBTNbox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioBTNbox2);
            this.groupBox1.Location = new System.Drawing.Point(735, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Em qual Box da tela deve ficar";
            // 
            // txtNomeDoFilme
            // 
            this.txtNomeDoFilme.BackColor = System.Drawing.Color.White;
            this.txtNomeDoFilme.Location = new System.Drawing.Point(728, 36);
            this.txtNomeDoFilme.Name = "txtNomeDoFilme";
            this.txtNomeDoFilme.Size = new System.Drawing.Size(213, 20);
            this.txtNomeDoFilme.TabIndex = 12;
            this.txtNomeDoFilme.Text = "Nome do Filme";
            // 
            // checkedListGen
            // 
            this.checkedListGen.BackColor = System.Drawing.Color.White;
            this.checkedListGen.FormattingEnabled = true;
            this.checkedListGen.Items.AddRange(new object[] {
            "acao",
            "aventura",
            "drama",
            "terror"});
            this.checkedListGen.Location = new System.Drawing.Point(778, 203);
            this.checkedListGen.Name = "checkedListGen";
            this.checkedListGen.Size = new System.Drawing.Size(128, 124);
            this.checkedListGen.TabIndex = 13;
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUser.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.White;
            this.TxtUser.Location = new System.Drawing.Point(12, 476);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(113, 20);
            this.TxtUser.TabIndex = 14;
            this.TxtUser.Text = "Mestre ";
            // 
            // adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
=======
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
>>>>>>> 06ff7e5b3077362c29c9341aadafde5dbd7f917a
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 498);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.checkedListGen);
            this.Controls.Add(this.txtNomeDoFilme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textNavegacao);
            this.Controls.Add(this.BtnUploadAll);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.imgload);
            this.Controls.Add(this.comboTagidade);
            this.Controls.Add(this.textsinopse);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "adminlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração";
            this.Load += new System.EventHandler(this.adminlogin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.imgload)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textsinopse;
        private System.Windows.Forms.ComboBox comboTagidade;
        private System.Windows.Forms.PictureBox imgload;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Button BtnUploadAll;
        private System.Windows.Forms.TextBox textNavegacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBTNbox1;
        private System.Windows.Forms.RadioButton radioBTNbox2;
        private System.Windows.Forms.RadioButton radioBTNbox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeDoFilme;
        private System.Windows.Forms.CheckedListBox checkedListGen;
        private System.Windows.Forms.TextBox TxtUser;
    }
}