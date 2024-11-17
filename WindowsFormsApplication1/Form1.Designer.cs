namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Universo = new System.Windows.Forms.RadioButton();
            this.rb_Galaxia = new System.Windows.Forms.RadioButton();
            this.btn_Pos1 = new System.Windows.Forms.Button();
            this.btn_Pos2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_clickTempo = new System.Windows.Forms.ComboBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.timerPoint1 = new System.Windows.Forms.Timer(this.components);
            this.timerPoint2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_P1 = new System.Windows.Forms.Label();
            this.lbl_P2 = new System.Windows.Forms.Label();
            this.btn_pos3 = new System.Windows.Forms.Button();
            this.lbl_avancaSS = new System.Windows.Forms.Label();
            this.lbl_avancaGalax = new System.Windows.Forms.Label();
            this.lbl_posBtnVer = new System.Windows.Forms.Label();
            this.btn_pos4 = new System.Windows.Forms.Button();
            this.lbl_recuaSS = new System.Windows.Forms.Label();
            this.lbl_actualizaGalax = new System.Windows.Forms.Label();
            this.cb_actualizaGalax = new System.Windows.Forms.ComboBox();
            this.timePoint3 = new System.Windows.Forms.Timer(this.components);
            this.timerPoint4 = new System.Windows.Forms.Timer(this.components);
            this.timerAvancaSS = new System.Windows.Forms.Timer(this.components);
            this.timerRecuaSS = new System.Windows.Forms.Timer(this.components);
            this.timerPressionaBTver = new System.Windows.Forms.Timer(this.components);
            this.timerAvancaGalaxia = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Universo);
            this.groupBox1.Controls.Add(this.rb_Galaxia);
            this.groupBox1.Location = new System.Drawing.Point(87, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo";
            // 
            // rb_Universo
            // 
            this.rb_Universo.AutoSize = true;
            this.rb_Universo.Location = new System.Drawing.Point(17, 41);
            this.rb_Universo.Name = "rb_Universo";
            this.rb_Universo.Size = new System.Drawing.Size(67, 17);
            this.rb_Universo.TabIndex = 1;
            this.rb_Universo.TabStop = true;
            this.rb_Universo.Text = "Universo";
            this.rb_Universo.UseVisualStyleBackColor = true;
            this.rb_Universo.CheckedChanged += new System.EventHandler(this.rb_Universo_CheckedChanged);
            // 
            // rb_Galaxia
            // 
            this.rb_Galaxia.AutoSize = true;
            this.rb_Galaxia.Location = new System.Drawing.Point(17, 18);
            this.rb_Galaxia.Name = "rb_Galaxia";
            this.rb_Galaxia.Size = new System.Drawing.Size(60, 17);
            this.rb_Galaxia.TabIndex = 0;
            this.rb_Galaxia.TabStop = true;
            this.rb_Galaxia.Text = "Galaxia";
            this.rb_Galaxia.UseVisualStyleBackColor = true;
            this.rb_Galaxia.CheckedChanged += new System.EventHandler(this.rb_Galaxia_CheckedChanged);
            // 
            // btn_Pos1
            // 
            this.btn_Pos1.Location = new System.Drawing.Point(12, 79);
            this.btn_Pos1.Name = "btn_Pos1";
            this.btn_Pos1.Size = new System.Drawing.Size(55, 23);
            this.btn_Pos1.TabIndex = 1;
            this.btn_Pos1.Text = "Pos 1";
            this.btn_Pos1.UseVisualStyleBackColor = true;
            this.btn_Pos1.Click += new System.EventHandler(this.btn_Pos1_Click);
            // 
            // btn_Pos2
            // 
            this.btn_Pos2.Location = new System.Drawing.Point(12, 108);
            this.btn_Pos2.Name = "btn_Pos2";
            this.btn_Pos2.Size = new System.Drawing.Size(55, 23);
            this.btn_Pos2.TabIndex = 2;
            this.btn_Pos2.Text = "Pos 2";
            this.btn_Pos2.UseVisualStyleBackColor = true;
            this.btn_Pos2.Click += new System.EventHandler(this.btn_Pos2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tempo de Click";
            // 
            // cb_clickTempo
            // 
            this.cb_clickTempo.FormattingEnabled = true;
            this.cb_clickTempo.Location = new System.Drawing.Point(13, 265);
            this.cb_clickTempo.Name = "cb_clickTempo";
            this.cb_clickTempo.Size = new System.Drawing.Size(55, 21);
            this.cb_clickTempo.TabIndex = 4;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(104, 263);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "AutoClick";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // timerPoint1
            // 
            this.timerPoint1.Tick += new System.EventHandler(this.timerPoint1_Tick);
            // 
            // timerPoint2
            // 
            this.timerPoint2.Tick += new System.EventHandler(this.timerPoint2_Tick);
            // 
            // lbl_P1
            // 
            this.lbl_P1.AutoSize = true;
            this.lbl_P1.Location = new System.Drawing.Point(84, 325);
            this.lbl_P1.Name = "lbl_P1";
            this.lbl_P1.Size = new System.Drawing.Size(35, 13);
            this.lbl_P1.TabIndex = 6;
            this.lbl_P1.Text = "lable1";
            // 
            // lbl_P2
            // 
            this.lbl_P2.AutoSize = true;
            this.lbl_P2.Location = new System.Drawing.Point(83, 348);
            this.lbl_P2.Name = "lbl_P2";
            this.lbl_P2.Size = new System.Drawing.Size(39, 13);
            this.lbl_P2.TabIndex = 7;
            this.lbl_P2.Text = "Lable2";
            // 
            // btn_pos3
            // 
            this.btn_pos3.Location = new System.Drawing.Point(12, 138);
            this.btn_pos3.Name = "btn_pos3";
            this.btn_pos3.Size = new System.Drawing.Size(55, 23);
            this.btn_pos3.TabIndex = 8;
            this.btn_pos3.Text = "Pos 3";
            this.btn_pos3.UseVisualStyleBackColor = true;
            this.btn_pos3.Click += new System.EventHandler(this.btn_pos3_Click);
            // 
            // lbl_avancaSS
            // 
            this.lbl_avancaSS.AutoSize = true;
            this.lbl_avancaSS.Location = new System.Drawing.Point(76, 84);
            this.lbl_avancaSS.Name = "lbl_avancaSS";
            this.lbl_avancaSS.Size = new System.Drawing.Size(101, 13);
            this.lbl_avancaSS.TabIndex = 9;
            this.lbl_avancaSS.Text = "Posição avanço SS";
            // 
            // lbl_avancaGalax
            // 
            this.lbl_avancaGalax.AutoSize = true;
            this.lbl_avancaGalax.Location = new System.Drawing.Point(79, 117);
            this.lbl_avancaGalax.Name = "lbl_avancaGalax";
            this.lbl_avancaGalax.Size = new System.Drawing.Size(95, 13);
            this.lbl_avancaGalax.TabIndex = 10;
            this.lbl_avancaGalax.Text = "Posição avanço G";
            // 
            // lbl_posBtnVer
            // 
            this.lbl_posBtnVer.AutoSize = true;
            this.lbl_posBtnVer.Location = new System.Drawing.Point(80, 148);
            this.lbl_posBtnVer.Name = "lbl_posBtnVer";
            this.lbl_posBtnVer.Size = new System.Drawing.Size(94, 13);
            this.lbl_posBtnVer.TabIndex = 11;
            this.lbl_posBtnVer.Text = "Posição Botão ver";
            // 
            // btn_pos4
            // 
            this.btn_pos4.Location = new System.Drawing.Point(12, 168);
            this.btn_pos4.Name = "btn_pos4";
            this.btn_pos4.Size = new System.Drawing.Size(55, 23);
            this.btn_pos4.TabIndex = 12;
            this.btn_pos4.Text = "Pos 4";
            this.btn_pos4.UseVisualStyleBackColor = true;
            this.btn_pos4.Click += new System.EventHandler(this.btn_pos4_Click);
            // 
            // lbl_recuaSS
            // 
            this.lbl_recuaSS.AutoSize = true;
            this.lbl_recuaSS.Location = new System.Drawing.Point(79, 177);
            this.lbl_recuaSS.Name = "lbl_recuaSS";
            this.lbl_recuaSS.Size = new System.Drawing.Size(100, 13);
            this.lbl_recuaSS.TabIndex = 13;
            this.lbl_recuaSS.Text = "Posição Recuar SS";
            // 
            // lbl_actualizaGalax
            // 
            this.lbl_actualizaGalax.AutoSize = true;
            this.lbl_actualizaGalax.Location = new System.Drawing.Point(11, 215);
            this.lbl_actualizaGalax.Name = "lbl_actualizaGalax";
            this.lbl_actualizaGalax.Size = new System.Drawing.Size(105, 13);
            this.lbl_actualizaGalax.TabIndex = 14;
            this.lbl_actualizaGalax.Text = "Actualizar n Galaxias";
            // 
            // cb_actualizaGalax
            // 
            this.cb_actualizaGalax.FormattingEnabled = true;
            this.cb_actualizaGalax.Location = new System.Drawing.Point(122, 212);
            this.cb_actualizaGalax.Name = "cb_actualizaGalax";
            this.cb_actualizaGalax.Size = new System.Drawing.Size(49, 21);
            this.cb_actualizaGalax.TabIndex = 15;
            this.cb_actualizaGalax.SelectedIndexChanged += new System.EventHandler(this.cb_actualizaGalax_SelectedIndexChanged);
            // 
            // timePoint3
            // 
            this.timePoint3.Tick += new System.EventHandler(this.timePoint3_Tick);
            // 
            // timerPoint4
            // 
            this.timerPoint4.Tick += new System.EventHandler(this.timerPoint4_Tick);
            // 
            // timerAvancaSS
            // 
            this.timerAvancaSS.Tick += new System.EventHandler(this.timerAvancaSS_Tick);
            // 
            // timerRecuaSS
            // 
            this.timerRecuaSS.Tick += new System.EventHandler(this.timerRecuaSS_Tick);
            // 
            // timerAvancaGalaxia
            // 
            this.timerAvancaGalaxia.Tick += new System.EventHandler(this.timerAvancaGalaxia_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.UP3;
            this.pictureBox1.Location = new System.Drawing.Point(16, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(187, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_actualizaGalax);
            this.Controls.Add(this.lbl_actualizaGalax);
            this.Controls.Add(this.lbl_recuaSS);
            this.Controls.Add(this.btn_pos4);
            this.Controls.Add(this.lbl_posBtnVer);
            this.Controls.Add(this.lbl_avancaGalax);
            this.Controls.Add(this.lbl_avancaSS);
            this.Controls.Add(this.btn_pos3);
            this.Controls.Add(this.lbl_P2);
            this.Controls.Add(this.lbl_P1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.cb_clickTempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Pos2);
            this.Controls.Add(this.btn_Pos1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(1080, 110);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Universo;
        private System.Windows.Forms.RadioButton rb_Galaxia;
        private System.Windows.Forms.Button btn_Pos1;
        private System.Windows.Forms.Button btn_Pos2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_clickTempo;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Timer timerPoint1;
        private System.Windows.Forms.Timer timerPoint2;
        private System.Windows.Forms.Label lbl_P1;
        private System.Windows.Forms.Label lbl_P2;
        private System.Windows.Forms.Button btn_pos3;
        private System.Windows.Forms.Label lbl_avancaSS;
        private System.Windows.Forms.Label lbl_avancaGalax;
        private System.Windows.Forms.Label lbl_posBtnVer;
        private System.Windows.Forms.Button btn_pos4;
        private System.Windows.Forms.Label lbl_recuaSS;
        private System.Windows.Forms.Label lbl_actualizaGalax;
        private System.Windows.Forms.ComboBox cb_actualizaGalax;
        private System.Windows.Forms.Timer timePoint3;
        private System.Windows.Forms.Timer timerPoint4;
        private System.Windows.Forms.Timer timerAvancaSS;
        private System.Windows.Forms.Timer timerRecuaSS;
        private System.Windows.Forms.Timer timerPressionaBTver;
        private System.Windows.Forms.Timer timerAvancaGalaxia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

