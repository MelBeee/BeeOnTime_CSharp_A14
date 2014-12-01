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
            this.TB_Repetition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FB_Annuler = new FlashButton.FlashButton();
            this.FB_Ajouter = new FlashButton.FlashButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Choix_De_Saut = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TB_Repetition
            // 
            this.TB_Repetition.Location = new System.Drawing.Point(40, 75);
            this.TB_Repetition.Name = "TB_Repetition";
            this.TB_Repetition.Size = new System.Drawing.Size(116, 18);
            this.TB_Repetition.TabIndex = 2;
            this.TB_Repetition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 59);
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
            this.FB_Annuler.Location = new System.Drawing.Point(101, 108);
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
            this.FB_Ajouter.Location = new System.Drawing.Point(15, 108);
            this.FB_Ajouter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FB_Ajouter.Name = "FB_Ajouter";
            this.FB_Ajouter.Size = new System.Drawing.Size(83, 30);
            this.FB_Ajouter.TabIndex = 64;
            this.FB_Ajouter.Click += new System.EventHandler(this.FB_Ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 11);
            this.label2.TabIndex = 69;
            this.label2.Text = "Fréquence";
            // 
            // CB_Choix_De_Saut
            // 
            this.CB_Choix_De_Saut.AutoCompleteCustomSource.AddRange(new string[] {
            "Jour",
            "Semaine",
            "Mois",
            "Année"});
            this.CB_Choix_De_Saut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Choix_De_Saut.FormattingEnabled = true;
            this.CB_Choix_De_Saut.Items.AddRange(new object[] {
            "Jour",
            "Semaine",
            "Mois",
            "Année"});
            this.CB_Choix_De_Saut.Location = new System.Drawing.Point(44, 27);
            this.CB_Choix_De_Saut.Name = "CB_Choix_De_Saut";
            this.CB_Choix_De_Saut.Size = new System.Drawing.Size(108, 19);
            this.CB_Choix_De_Saut.TabIndex = 1;
            this.CB_Choix_De_Saut.SelectedIndexChanged += new System.EventHandler(this.CB_Choix_De_Saut_SelectedIndexChanged);
            // 
            // DuplicataEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(196, 152);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Choix_De_Saut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Repetition);
            this.Controls.Add(this.FB_Annuler);
            this.Controls.Add(this.FB_Ajouter);
            this.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(212, 186);
            this.MinimumSize = new System.Drawing.Size(212, 186);
            this.Name = "DuplicataEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuplicataEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DuplicataEvent_FormClosing);
            this.Load += new System.EventHandler(this.DuplicataEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlashButton.FlashButton FB_Annuler;
        private FlashButton.FlashButton FB_Ajouter;
        private System.Windows.Forms.TextBox TB_Repetition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Choix_De_Saut;
    }
}