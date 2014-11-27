using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compact_Agenda
{
    public partial class Aide : Form
    {
        public Aide()
        {
            InitializeComponent();
        }

        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aide_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PositionAide;
        }

        private void Aide_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PositionAide = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
