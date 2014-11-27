namespace Compact_Agenda
{
    partial class DuplicataEvent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FB_Annuler = new FlashButton.FlashButton();
            this.FB_Ajouter = new FlashButton.FlashButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dupliquer";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 55);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(114, 15);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Tous les mois";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(142, 15);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tous les semaines";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 15);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tous les jours";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 18);
            this.textBox1.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 11);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nombre de répétitions";
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
            this.FB_Annuler.Location = new System.Drawing.Point(101, 144);
            this.FB_Annuler.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FB_Annuler.Name = "FB_Annuler";
            this.FB_Annuler.Size = new System.Drawing.Size(83, 30);
            this.FB_Annuler.TabIndex = 65;
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
            this.FB_Ajouter.Location = new System.Drawing.Point(15, 144);
            this.FB_Ajouter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FB_Ajouter.Name = "FB_Ajouter";
            this.FB_Ajouter.Size = new System.Drawing.Size(83, 30);
            this.FB_Ajouter.TabIndex = 64;
            this.FB_Ajouter.Click += new System.EventHandler(this.FB_Ajouter_Click);
            // 
            // DuplicataEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(196, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FB_Annuler);
            this.Controls.Add(this.FB_Ajouter);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(212, 214);
            this.MinimumSize = new System.Drawing.Size(212, 214);
            this.Name = "DuplicataEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuplicataEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DuplicataEvent_FormClosing);
            this.Load += new System.EventHandler(this.DuplicataEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FlashButton.FlashButton FB_Annuler;
        private FlashButton.FlashButton FB_Ajouter;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}