namespace Compact_Agenda
{
    partial class Form_WeekView
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
            System.Windows.Forms.ToolStripMenuItem CMS_ReporterEvent;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_WeekView));
            this.PN_Frame = new System.Windows.Forms.Panel();
            this.UCS_HauteurCase = new UC_Slider.UC_Slider();
            this.CMS_EnteteHeure = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_CouleurEnteteHeure = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_FontEnteteHeure = new System.Windows.Forms.ToolStripMenuItem();
            this.PN_Scroll = new Compact_Agenda.DoubleBufferPanel();
            this.CMS_FondSemaineCourante = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_CouleurSemaine = new System.Windows.Forms.ToolStripMenuItem();
            this.changerLaCouleurDesLignesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_HorizontaleSemaine = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_VerticalesSemaine = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_FontSemaine = new System.Windows.Forms.ToolStripMenuItem();
            this.PN_Content = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Hours = new Compact_Agenda.DoubleBufferPanel();
            this.FBTN_DecrementWeek = new FlashButton.FlashButton();
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.PN_DaysHeader = new Compact_Agenda.DoubleBufferPanel();
            this.CMS_EnteteJournee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_DateCouranteEnteteJournee = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_CouleurEnteteJournee = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_FontEnteteJournee = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Evenement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_ModifierEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_EffacerEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_DupliquerEvent = new System.Windows.Forms.ToolStripMenuItem();
            CMS_ReporterEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.PN_Frame.SuspendLayout();
            this.CMS_EnteteHeure.SuspendLayout();
            this.PN_Scroll.SuspendLayout();
            this.CMS_FondSemaineCourante.SuspendLayout();
            this.CMS_EnteteJournee.SuspendLayout();
            this.CMS_Evenement.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMS_ReporterEvent
            // 
            CMS_ReporterEvent.Name = "CMS_ReporterEvent";
            CMS_ReporterEvent.Size = new System.Drawing.Size(199, 22);
            CMS_ReporterEvent.Text = "Reporter d\'une semaine";
            CMS_ReporterEvent.Click += new System.EventHandler(this.CMS_ReporterEvent_Click);
            // 
            // PN_Frame
            // 
            this.PN_Frame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Frame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.PN_Frame.Controls.Add(this.UCS_HauteurCase);
            this.PN_Frame.Controls.Add(this.PN_Scroll);
            this.PN_Frame.Controls.Add(this.FBTN_DecrementWeek);
            this.PN_Frame.Controls.Add(this.FBTN_IncrementWeek);
            this.PN_Frame.Controls.Add(this.PN_DaysHeader);
            this.PN_Frame.Location = new System.Drawing.Point(0, 0);
            this.PN_Frame.Name = "PN_Frame";
            this.PN_Frame.Size = new System.Drawing.Size(743, 589);
            this.PN_Frame.TabIndex = 4;
            // 
            // UCS_HauteurCase
            // 
            this.UCS_HauteurCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UCS_HauteurCase.BarDisableImage = ((System.Drawing.Image)(resources.GetObject("UCS_HauteurCase.BarDisableImage")));
            this.UCS_HauteurCase.BarEnableImage = ((System.Drawing.Image)(resources.GetObject("UCS_HauteurCase.BarEnableImage")));
            this.UCS_HauteurCase.ContextMenuStrip = this.CMS_EnteteHeure;
            this.UCS_HauteurCase.CursorDisableImage = ((System.Drawing.Image)(resources.GetObject("UCS_HauteurCase.CursorDisableImage")));
            this.UCS_HauteurCase.CursorEnableImage = ((System.Drawing.Image)(resources.GetObject("UCS_HauteurCase.CursorEnableImage")));
            this.UCS_HauteurCase.CursorOverImage = ((System.Drawing.Image)(resources.GetObject("UCS_HauteurCase.CursorOverImage")));
            this.UCS_HauteurCase.Location = new System.Drawing.Point(4, 35);
            this.UCS_HauteurCase.Maximum = 100;
            this.UCS_HauteurCase.Minimum = -100;
            this.UCS_HauteurCase.Name = "UCS_HauteurCase";
            this.UCS_HauteurCase.Size = new System.Drawing.Size(34, 549);
            this.UCS_HauteurCase.TabIndex = 0;
            this.UCS_HauteurCase.Value = 0;
            this.UCS_HauteurCase.Visible = false;
            this.UCS_HauteurCase.ValueChanged += new UC_Slider.UC_Slider.ValueChangedHandler(this.UCS_HauteurCase_ValueChanged);
            // 
            // CMS_EnteteHeure
            // 
            this.CMS_EnteteHeure.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_CouleurEnteteHeure,
            this.CMS_FontEnteteHeure});
            this.CMS_EnteteHeure.Name = "CMS_EnteteHeure";
            this.CMS_EnteteHeure.Size = new System.Drawing.Size(176, 48);
            // 
            // CMS_CouleurEnteteHeure
            // 
            this.CMS_CouleurEnteteHeure.Name = "CMS_CouleurEnteteHeure";
            this.CMS_CouleurEnteteHeure.Size = new System.Drawing.Size(175, 22);
            this.CMS_CouleurEnteteHeure.Text = "Couleur de fond...";
            this.CMS_CouleurEnteteHeure.Click += new System.EventHandler(this.CMS_CouleurEnteteHeure_Click);
            // 
            // CMS_FontEnteteHeure
            // 
            this.CMS_FontEnteteHeure.Name = "CMS_FontEnteteHeure";
            this.CMS_FontEnteteHeure.Size = new System.Drawing.Size(175, 22);
            this.CMS_FontEnteteHeure.Text = "Changer la police...";
            this.CMS_FontEnteteHeure.Click += new System.EventHandler(this.CMS_FontEnteteHeure_Click);
            // 
            // PN_Scroll
            // 
            this.PN_Scroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Scroll.AutoScroll = true;
            this.PN_Scroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(176)))));
            this.PN_Scroll.ContextMenuStrip = this.CMS_EnteteHeure;
            this.PN_Scroll.Controls.Add(this.PN_Content);
            this.PN_Scroll.Controls.Add(this.PN_Hours);
            this.PN_Scroll.Location = new System.Drawing.Point(3, 34);
            this.PN_Scroll.Margin = new System.Windows.Forms.Padding(0);
            this.PN_Scroll.Name = "PN_Scroll";
            this.PN_Scroll.Size = new System.Drawing.Size(737, 552);
            this.PN_Scroll.TabIndex = 1;
            this.PN_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PN_Scroll_Scroll);
            this.PN_Scroll.Resize += new System.EventHandler(this.PN_Scroll_Resize);
            // 
            // CMS_FondSemaineCourante
            // 
            this.CMS_FondSemaineCourante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_CouleurSemaine,
            this.changerLaCouleurDesLignesToolStripMenuItem,
            this.CMS_FontSemaine});
            this.CMS_FondSemaineCourante.Name = "CMS_FondSemaineCourante";
            this.CMS_FondSemaineCourante.Size = new System.Drawing.Size(230, 70);
            // 
            // CMS_CouleurSemaine
            // 
            this.CMS_CouleurSemaine.Name = "CMS_CouleurSemaine";
            this.CMS_CouleurSemaine.Size = new System.Drawing.Size(229, 22);
            this.CMS_CouleurSemaine.Text = "Changer la couleur de fond...";
            this.CMS_CouleurSemaine.Click += new System.EventHandler(this.CMS_CouleurSemaine_Click);
            // 
            // changerLaCouleurDesLignesToolStripMenuItem
            // 
            this.changerLaCouleurDesLignesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_HorizontaleSemaine,
            this.CMS_VerticalesSemaine});
            this.changerLaCouleurDesLignesToolStripMenuItem.Name = "changerLaCouleurDesLignesToolStripMenuItem";
            this.changerLaCouleurDesLignesToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.changerLaCouleurDesLignesToolStripMenuItem.Text = "Changer la couleur des lignes";
            // 
            // CMS_HorizontaleSemaine
            // 
            this.CMS_HorizontaleSemaine.Name = "CMS_HorizontaleSemaine";
            this.CMS_HorizontaleSemaine.Size = new System.Drawing.Size(140, 22);
            this.CMS_HorizontaleSemaine.Text = "Horizontales";
            this.CMS_HorizontaleSemaine.Click += new System.EventHandler(this.CMS_HorizontaleSemaine_Click);
            // 
            // CMS_VerticalesSemaine
            // 
            this.CMS_VerticalesSemaine.Name = "CMS_VerticalesSemaine";
            this.CMS_VerticalesSemaine.Size = new System.Drawing.Size(140, 22);
            this.CMS_VerticalesSemaine.Text = "Verticales";
            this.CMS_VerticalesSemaine.Click += new System.EventHandler(this.CMS_VerticalesSemaine_Click);
            // 
            // CMS_FontSemaine
            // 
            this.CMS_FontSemaine.Name = "CMS_FontSemaine";
            this.CMS_FontSemaine.Size = new System.Drawing.Size(229, 22);
            this.CMS_FontSemaine.Text = "Changer la police...";
            this.CMS_FontSemaine.Click += new System.EventHandler(this.CMS_FontSemaine_Click);
            // 
            // PN_Content
            // 
            this.PN_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PN_Content.Location = new System.Drawing.Point(36, 0);
            this.PN_Content.Name = "PN_Content";
            this.PN_Content.Size = new System.Drawing.Size(628, 522);
            this.PN_Content.TabIndex = 0;
            this.PN_Content.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Content_Paint);
            this.PN_Content.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseClick);
            this.PN_Content.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDoubleClick);
            this.PN_Content.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDown);
            this.PN_Content.MouseEnter += new System.EventHandler(this.PN_Scroll_MouseEnter);
            this.PN_Content.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseMove);
            this.PN_Content.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseUp);
            this.PN_Content.Resize += new System.EventHandler(this.PN_Content_Resize);
            // 
            // PN_Hours
            // 
            this.PN_Hours.Font = new System.Drawing.Font("Lucida Console", 8.3F);
            this.PN_Hours.Location = new System.Drawing.Point(0, 0);
            this.PN_Hours.Name = "PN_Hours";
            this.PN_Hours.Size = new System.Drawing.Size(36, 518);
            this.PN_Hours.TabIndex = 1;
            this.PN_Hours.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Hours_Paint);
            this.PN_Hours.MouseEnter += new System.EventHandler(this.PN_Hours_MouseEnter);
            // 
            // FBTN_DecrementWeek
            // 
            this.FBTN_DecrementWeek.BackgroundImage = global::Compact_Agenda.Properties.Resources.GaucheNormal;
            this.FBTN_DecrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_DecrementWeek.ImageClick = global::Compact_Agenda.Properties.Resources.GaucheClick;
            this.FBTN_DecrementWeek.ImageDisable = global::Compact_Agenda.Properties.Resources.GaucheClick;
            this.FBTN_DecrementWeek.ImageNeutral = global::Compact_Agenda.Properties.Resources.GaucheNormal;
            this.FBTN_DecrementWeek.ImageOver = global::Compact_Agenda.Properties.Resources.GaucheHover;
            this.FBTN_DecrementWeek.Location = new System.Drawing.Point(3, 2);
            this.FBTN_DecrementWeek.Margin = new System.Windows.Forms.Padding(4);
            this.FBTN_DecrementWeek.Name = "FBTN_DecrementWeek";
            this.FBTN_DecrementWeek.Size = new System.Drawing.Size(32, 32);
            this.FBTN_DecrementWeek.TabIndex = 2;
            this.FBTN_DecrementWeek.Click += new System.EventHandler(this.FBTN_DecrementWeek_Click);
            // 
            // FBTN_IncrementWeek
            // 
            this.FBTN_IncrementWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBTN_IncrementWeek.BackgroundImage = global::Compact_Agenda.Properties.Resources.DroiteNormal;
            this.FBTN_IncrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_IncrementWeek.ImageClick = global::Compact_Agenda.Properties.Resources.DroiteClick;
            this.FBTN_IncrementWeek.ImageDisable = global::Compact_Agenda.Properties.Resources.DroiteClick;
            this.FBTN_IncrementWeek.ImageNeutral = global::Compact_Agenda.Properties.Resources.DroiteNormal;
            this.FBTN_IncrementWeek.ImageOver = global::Compact_Agenda.Properties.Resources.DroiteHover;
            this.FBTN_IncrementWeek.Location = new System.Drawing.Point(708, 2);
            this.FBTN_IncrementWeek.Margin = new System.Windows.Forms.Padding(4);
            this.FBTN_IncrementWeek.Name = "FBTN_IncrementWeek";
            this.FBTN_IncrementWeek.Size = new System.Drawing.Size(32, 32);
            this.FBTN_IncrementWeek.TabIndex = 3;
            this.FBTN_IncrementWeek.Click += new System.EventHandler(this.FBTN_IncrementWeek_Click);
            // 
            // PN_DaysHeader
            // 
            this.PN_DaysHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.PN_DaysHeader.ContextMenuStrip = this.CMS_EnteteJournee;
            this.PN_DaysHeader.Font = new System.Drawing.Font("Lucida Console", 8.3F);
            this.PN_DaysHeader.Location = new System.Drawing.Point(39, 2);
            this.PN_DaysHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PN_DaysHeader.Name = "PN_DaysHeader";
            this.PN_DaysHeader.Size = new System.Drawing.Size(628, 32);
            this.PN_DaysHeader.TabIndex = 0;
            this.PN_DaysHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_DaysHeader_Paint);
            this.PN_DaysHeader.MouseEnter += new System.EventHandler(this.PN_DaysHeader_MouseEnter);
            // 
            // CMS_EnteteJournee
            // 
            this.CMS_EnteteJournee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_DateCouranteEnteteJournee,
            this.CMS_CouleurEnteteJournee,
            this.CMS_FontEnteteJournee});
            this.CMS_EnteteJournee.Name = "CMS_EnteteJournee";
            this.CMS_EnteteJournee.Size = new System.Drawing.Size(228, 70);
            // 
            // CMS_DateCouranteEnteteJournee
            // 
            this.CMS_DateCouranteEnteteJournee.Name = "CMS_DateCouranteEnteteJournee";
            this.CMS_DateCouranteEnteteJournee.Size = new System.Drawing.Size(227, 22);
            this.CMS_DateCouranteEnteteJournee.Text = "Changer la date courante...";
            this.CMS_DateCouranteEnteteJournee.Click += new System.EventHandler(this.CMS_DateCouranteEnteteJournee_Click);
            // 
            // CMS_CouleurEnteteJournee
            // 
            this.CMS_CouleurEnteteJournee.Name = "CMS_CouleurEnteteJournee";
            this.CMS_CouleurEnteteJournee.Size = new System.Drawing.Size(227, 22);
            this.CMS_CouleurEnteteJournee.Text = "Changer la couleur de fond...";
            this.CMS_CouleurEnteteJournee.Click += new System.EventHandler(this.CMS_CouleurEnteteJournee_Click);
            // 
            // CMS_FontEnteteJournee
            // 
            this.CMS_FontEnteteJournee.Name = "CMS_FontEnteteJournee";
            this.CMS_FontEnteteJournee.Size = new System.Drawing.Size(227, 22);
            this.CMS_FontEnteteJournee.Text = "Changer la police...";
            this.CMS_FontEnteteJournee.Click += new System.EventHandler(this.CMS_FontEnteteJournee_Click);
            // 
            // CMS_Evenement
            // 
            this.CMS_Evenement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_ModifierEvent,
            this.CMS_EffacerEvent,
            CMS_ReporterEvent,
            this.CMS_DupliquerEvent});
            this.CMS_Evenement.Name = "CMS_Evenement";
            this.CMS_Evenement.Size = new System.Drawing.Size(200, 92);
            // 
            // CMS_ModifierEvent
            // 
            this.CMS_ModifierEvent.Name = "CMS_ModifierEvent";
            this.CMS_ModifierEvent.Size = new System.Drawing.Size(199, 22);
            this.CMS_ModifierEvent.Text = "Modifier...";
            this.CMS_ModifierEvent.Click += new System.EventHandler(this.CMS_ModifierEvent_Click);
            // 
            // CMS_EffacerEvent
            // 
            this.CMS_EffacerEvent.Name = "CMS_EffacerEvent";
            this.CMS_EffacerEvent.Size = new System.Drawing.Size(199, 22);
            this.CMS_EffacerEvent.Text = "Effacer";
            this.CMS_EffacerEvent.Click += new System.EventHandler(this.CMS_EffacerEvent_Click);
            // 
            // CMS_DupliquerEvent
            // 
            this.CMS_DupliquerEvent.Name = "CMS_DupliquerEvent";
            this.CMS_DupliquerEvent.Size = new System.Drawing.Size(199, 22);
            this.CMS_DupliquerEvent.Text = "Dupliquer...";
            this.CMS_DupliquerEvent.Click += new System.EventHandler(this.CMS_DupliquerEvent_Click);
            // 
            // Form_WeekView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 589);
            this.Controls.Add(this.PN_Frame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form_WeekView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bee on Time...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_WeekView_FormClosing);
            this.Load += new System.EventHandler(this.Form_WeekView_Load);
            this.PN_Frame.ResumeLayout(false);
            this.CMS_EnteteHeure.ResumeLayout(false);
            this.PN_Scroll.ResumeLayout(false);
            this.CMS_FondSemaineCourante.ResumeLayout(false);
            this.CMS_EnteteJournee.ResumeLayout(false);
            this.CMS_Evenement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferPanel PN_DaysHeader;
        private DoubleBufferPanel PN_Scroll;
        private DoubleBufferPanel PN_Content;
        private DoubleBufferPanel PN_Hours;
        private FlashButton.FlashButton FBTN_DecrementWeek;
        private FlashButton.FlashButton FBTN_IncrementWeek;
        private System.Windows.Forms.Panel PN_Frame;
        private UC_Slider.UC_Slider UCS_HauteurCase;
        private System.Windows.Forms.ContextMenuStrip CMS_EnteteJournee;
        private System.Windows.Forms.ContextMenuStrip CMS_Evenement;
        private System.Windows.Forms.ContextMenuStrip CMS_EnteteHeure;
        private System.Windows.Forms.ContextMenuStrip CMS_FondSemaineCourante;
        private System.Windows.Forms.ToolStripMenuItem CMS_DateCouranteEnteteJournee;
        private System.Windows.Forms.ToolStripMenuItem CMS_CouleurEnteteJournee;
        private System.Windows.Forms.ToolStripMenuItem CMS_FontEnteteJournee;
        private System.Windows.Forms.ToolStripMenuItem CMS_ModifierEvent;
        private System.Windows.Forms.ToolStripMenuItem CMS_EffacerEvent;
        private System.Windows.Forms.ToolStripMenuItem CMS_DupliquerEvent;
        private System.Windows.Forms.ToolStripMenuItem CMS_CouleurEnteteHeure;
        private System.Windows.Forms.ToolStripMenuItem CMS_FontEnteteHeure;
        private System.Windows.Forms.ToolStripMenuItem CMS_CouleurSemaine;
        private System.Windows.Forms.ToolStripMenuItem changerLaCouleurDesLignesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMS_HorizontaleSemaine;
        private System.Windows.Forms.ToolStripMenuItem CMS_VerticalesSemaine;
        private System.Windows.Forms.ToolStripMenuItem CMS_FontSemaine;

    }
}