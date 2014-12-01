using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///////////////////////////////////////////////////////////////////
//
//      Fait par Xavier Brosseau et Melissa Boucher
//
///////////////////////////////////////////////////////////////////

namespace Compact_Agenda
{
    public partial class ChoixDate : Form
    {
        public ChoixDate()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Properties.Settings.Default.DateCourante = Cal_ChoixDate.SelectionStart;
            Properties.Settings.Default.Save();
        }

        private void FB_Ajouter_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FB_Annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void ChoixDate_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PositionChoixDate;
        }

        private void ChoixDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PositionChoixDate = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
