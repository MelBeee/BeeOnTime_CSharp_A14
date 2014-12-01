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
    public partial class DuplicataEvent : Form
    {
        public DuplicataEvent()
        {
            InitializeComponent();
        }

        const char BACKSPACE = '\b';
        bool EstChiffre(char c)
        {
            String chiffres = "0123456789";
            return (chiffres.IndexOf(c.ToString()) != -1);
        }

        private void FB_Ajouter_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        public string GetInterval()
        {
            return CB_Choix_De_Saut.SelectedItem.ToString();
        }

        //retourne le choix de l'utilisateur 
        public int GetNbFois()
        {
            return Int32.Parse(TB_Repetition.Text);
        }

        private void FB_Annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void DuplicataEvent_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PositionDuplicata;
            CB_Choix_De_Saut.SelectedIndex = 0; 
        }

        private void DuplicataEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PositionDuplicata = this.Location;
            Properties.Settings.Default.Save();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != BACKSPACE)
                e.Handled = !EstChiffre(e.KeyChar);
        }

        private void CB_Choix_De_Saut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
