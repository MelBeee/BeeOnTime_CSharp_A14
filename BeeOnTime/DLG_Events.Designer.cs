namespace Compact_Agenda
{
    partial class DLG_Events
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
            this.label6 = new System.Windows.Forms.Label();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.TBX_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_Title = new System.Windows.Forms.TextBox();
            this.NUD_MinuteFin = new System.Windows.Forms.NumericUpDown();
            this.NUD_HeureFin = new System.Windows.Forms.NumericUpDown();
            this.NUD_MinuteDebut = new System.Windows.Forms.NumericUpDown();
            this.NUD_HeureDebut = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BTN_Effacer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FB_Annuler = new FlashButton.FlashButton();
            this.FB_Ajouter = new FlashButton.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MinuteFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_HeureFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MinuteDebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_HeureDebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.label6.Location = new System.Drawing.Point(51, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 11);
            this.label6.TabIndex = 65;
            this.label6.Text = "Type";
            // 
            // CB_Type
            // 
            this.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Items.AddRange(new object[] {
            "Général",
            "Travail",
            "Loisir",
            "Santé",
            "Important",
            "Autre"});
            this.CB_Type.Location = new System.Drawing.Point(89, 193);
            this.CB_Type.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(91, 21);
            this.CB_Type.TabIndex = 61;
            this.CB_Type.SelectedIndexChanged += new System.EventHandler(this.CB_Type_SelectedIndexChanged);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(90, 114);
            this.DTP_Date.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DTP_Date.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.DTP_Date.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(102, 20);
            this.DTP_Date.TabIndex = 58;
            // 
            // TBX_Description
            // 
            this.TBX_Description.Location = new System.Drawing.Point(90, 30);
            this.TBX_Description.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TBX_Description.Multiline = true;
            this.TBX_Description.Name = "TBX_Description";
            this.TBX_Description.Size = new System.Drawing.Size(176, 76);
            this.TBX_Description.TabIndex = 53;
            this.TBX_Description.TextChanged += new System.EventHandler(this.TBX_Description_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.label3.Location = new System.Drawing.Point(51, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 11);
            this.label3.TabIndex = 55;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 11);
            this.label2.TabIndex = 56;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.label1.Location = new System.Drawing.Point(46, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 11);
            this.label1.TabIndex = 57;
            this.label1.Text = "Titre";
            // 
            // TBX_Title
            // 
            this.TBX_Title.Location = new System.Drawing.Point(90, 6);
            this.TBX_Title.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TBX_Title.Name = "TBX_Title";
            this.TBX_Title.Size = new System.Drawing.Size(90, 20);
            this.TBX_Title.TabIndex = 51;
            this.TBX_Title.TextChanged += new System.EventHandler(this.TBX_Title_TextChanged);
            // 
            // NUD_MinuteFin
            // 
            this.NUD_MinuteFin.Location = new System.Drawing.Point(128, 167);
            this.NUD_MinuteFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUD_MinuteFin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUD_MinuteFin.Name = "NUD_MinuteFin";
            this.NUD_MinuteFin.Size = new System.Drawing.Size(32, 20);
            this.NUD_MinuteFin.TabIndex = 77;
            this.NUD_MinuteFin.ValueChanged += new System.EventHandler(this.NUD_MinuteFin_ValueChanged);
            // 
            // NUD_HeureFin
            // 
            this.NUD_HeureFin.Location = new System.Drawing.Point(90, 167);
            this.NUD_HeureFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUD_HeureFin.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUD_HeureFin.Name = "NUD_HeureFin";
            this.NUD_HeureFin.Size = new System.Drawing.Size(32, 20);
            this.NUD_HeureFin.TabIndex = 76;
            this.NUD_HeureFin.ValueChanged += new System.EventHandler(this.NUD_HeureFin_ValueChanged);
            // 
            // NUD_MinuteDebut
            // 
            this.NUD_MinuteDebut.Location = new System.Drawing.Point(128, 141);
            this.NUD_MinuteDebut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUD_MinuteDebut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUD_MinuteDebut.Name = "NUD_MinuteDebut";
            this.NUD_MinuteDebut.Size = new System.Drawing.Size(32, 20);
            this.NUD_MinuteDebut.TabIndex = 75;
            this.NUD_MinuteDebut.ValueChanged += new System.EventHandler(this.NUD_MinuteDebut_ValueChanged);
            // 
            // NUD_HeureDebut
            // 
            this.NUD_HeureDebut.Location = new System.Drawing.Point(90, 141);
            this.NUD_HeureDebut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUD_HeureDebut.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUD_HeureDebut.Name = "NUD_HeureDebut";
            this.NUD_HeureDebut.Size = new System.Drawing.Size(32, 20);
            this.NUD_HeureDebut.TabIndex = 74;
            this.NUD_HeureDebut.ValueChanged += new System.EventHandler(this.NUD_HeureDebut_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.label7.Location = new System.Drawing.Point(58, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 11);
            this.label7.TabIndex = 72;
            this.label7.Text = "Fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.label8.Location = new System.Drawing.Point(46, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 11);
            this.label8.TabIndex = 73;
            this.label8.Text = "Début";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(120, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 15);
            this.label9.TabIndex = 78;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(119, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 15);
            this.label10.TabIndex = 79;
            this.label10.Text = ":";
            // 
            // BTN_Effacer
            // 
            this.BTN_Effacer.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.BTN_Effacer.Location = new System.Drawing.Point(203, 6);
            this.BTN_Effacer.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTN_Effacer.Name = "BTN_Effacer";
            this.BTN_Effacer.Size = new System.Drawing.Size(55, 18);
            this.BTN_Effacer.TabIndex = 64;
            this.BTN_Effacer.Text = "Effacer";
            this.BTN_Effacer.UseVisualStyleBackColor = true;
            this.BTN_Effacer.Click += new System.EventHandler(this.BTN_Effacer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Compact_Agenda.Properties.Resources.large_bee2;
            this.pictureBox2.Location = new System.Drawing.Point(23, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Compact_Agenda.Properties.Resources.large_bee;
            this.pictureBox1.Location = new System.Drawing.Point(203, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // FB_Annuler
            // 
            this.FB_Annuler.BackColor = System.Drawing.Color.Transparent;
            this.FB_Annuler.BackgroundImage = global::Compact_Agenda.Properties.Resources.AnnulerNormal;
            this.FB_Annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Annuler.ImageClick = global::Compact_Agenda.Properties.Resources.AnnulerClick;
            this.FB_Annuler.ImageDisable = global::Compact_Agenda.Properties.Resources.AnnulerDisable;
            this.FB_Annuler.ImageNeutral = global::Compact_Agenda.Properties.Resources.AnnulerNormal;
            this.FB_Annuler.ImageOver = global::Compact_Agenda.Properties.Resources.AnnulerHover;
            this.FB_Annuler.Location = new System.Drawing.Point(143, 222);
            this.FB_Annuler.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.FB_Annuler.Name = "FB_Annuler";
            this.FB_Annuler.Size = new System.Drawing.Size(85, 32);
            this.FB_Annuler.TabIndex = 63;
            this.FB_Annuler.Click += new System.EventHandler(this.FB_Annuler_Click);
            // 
            // FB_Ajouter
            // 
            this.FB_Ajouter.BackgroundImage = global::Compact_Agenda.Properties.Resources.AjouterNormal;
            this.FB_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Ajouter.ImageClick = global::Compact_Agenda.Properties.Resources.AjouterClick;
            this.FB_Ajouter.ImageDisable = global::Compact_Agenda.Properties.Resources.AjouterDisable;
            this.FB_Ajouter.ImageNeutral = global::Compact_Agenda.Properties.Resources.AjouterNormal;
            this.FB_Ajouter.ImageOver = global::Compact_Agenda.Properties.Resources.AjouterHover;
            this.FB_Ajouter.Location = new System.Drawing.Point(54, 222);
            this.FB_Ajouter.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.FB_Ajouter.Name = "FB_Ajouter";
            this.FB_Ajouter.Size = new System.Drawing.Size(85, 32);
            this.FB_Ajouter.TabIndex = 62;
            this.FB_Ajouter.Click += new System.EventHandler(this.FB_Ajouter_Click);
            // 
            // DLG_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(280, 264);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NUD_MinuteFin);
            this.Controls.Add(this.NUD_HeureFin);
            this.Controls.Add(this.NUD_MinuteDebut);
            this.Controls.Add(this.NUD_HeureDebut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CB_Type);
            this.Controls.Add(this.FB_Annuler);
            this.Controls.Add(this.FB_Ajouter);
            this.Controls.Add(this.BTN_Effacer);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.TBX_Description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(296, 298);
            this.MinimumSize = new System.Drawing.Size(296, 298);
            this.Name = "DLG_Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter/Modifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_Events_FormClosing);
            this.Load += new System.EventHandler(this.DLG_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MinuteFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_HeureFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MinuteDebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_HeureDebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_Type;
        private FlashButton.FlashButton FB_Annuler;
        private FlashButton.FlashButton FB_Ajouter;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.TextBox TBX_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_Title;
        private System.Windows.Forms.NumericUpDown NUD_MinuteFin;
        private System.Windows.Forms.NumericUpDown NUD_HeureFin;
        private System.Windows.Forms.NumericUpDown NUD_MinuteDebut;
        private System.Windows.Forms.NumericUpDown NUD_HeureDebut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTN_Effacer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}