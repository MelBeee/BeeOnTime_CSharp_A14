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
    public partial class DuplicataEvent : Form
    {
        public DuplicataEvent()
        {
            InitializeComponent();
        }

        private void FB_Ajouter_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FB_Annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void DuplicataEvent_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PositionDuplicata;
        }

        private void DuplicataEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PositionDuplicata = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
