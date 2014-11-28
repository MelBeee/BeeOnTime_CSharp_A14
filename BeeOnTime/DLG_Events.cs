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
    public partial class DLG_Events : Form
    {
        public Event Event { get; set; }
        private bool blockUpdate;
        public bool delete = false;
        public DLG_Events()
        {
            InitializeComponent();
        }

        private void DLG_Events_Load(object sender, EventArgs e)
        {
            delete = false;
            this.Location = Properties.Settings.Default.PositionEvents;
            try
            {
                CB_Type.SelectedIndex = TrouverIndex();
            }
            catch
            {
                CB_Type.SelectedIndex = 0;
            }

            EventToDLG();
            if (UpdateControls())
            {
                FB_Ajouter.Enabled = false;
            }
            else
            {
                FB_Ajouter.Enabled = true;
            }
        }

        public bool UpdateControls()
        {
            return (TBX_Description.Text == "" || TBX_Title.Text == "");
        }

        public static DateTime Klone(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0);
        }

        private void EventToDLG()
        {
            if (Event != null)
            {
                TBX_Title.Text = Event.Title;
                TBX_Description.Text = Event.Description;
                blockUpdate = true;
                DTP_Date.Value = Klone(Event.Starting);
                NUD_HeureDebut.Value = Event.Starting.Hour;
                NUD_MinuteDebut.Value = Event.Starting.Minute;
                NUD_HeureFin.Value = Event.Ending.Hour;
                NUD_MinuteFin.Value = Event.Ending.Minute;
                blockUpdate = false;
            }
            else
                Event = new Event();
        }

        private int TrouverIndex()
        {
            int index;
            switch (Event.TypeEvenement.ToString())
            {
                case "Général":
                    index = 0;
                    break;
                case "Travail":
                    index = 1;
                    break;
                case "Loisir":
                    index = 2;
                    break;
                case "Santé":
                    index = 3;
                    break;
                case "Important":
                    index = 4;
                    break;
                case "Autre":
                    index = 5;
                    break;
                default:
                    index = 0;
                    break;
            }
            return index;
        }

        private void TBX_Title_TextChanged(object sender, EventArgs e)
        {
            Event.Title = TBX_Title.Text;
            if (UpdateControls())
            {
                FB_Ajouter.Enabled = false;
            }
            else
            {
                FB_Ajouter.Enabled = true;
            }
        }

        private void TBX_Description_TextChanged(object sender, EventArgs e)
        {
            Event.Description = TBX_Description.Text;
            if (UpdateControls())
            {
                FB_Ajouter.Enabled = false;
            }
            else
            {
                FB_Ajouter.Enabled = true;
            }
        }

        private void BTN_Effacer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment effacer cet événement ?") == System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                delete = true;
                this.Close();
            }
        }

        private void FB_Ajouter_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FB_Annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void CB_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event.TypeEvenement = CB_Type.Text;
        }

        private void NUD_MinuteFin_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                DTP_Date.Value.Month,
                                                DTP_Date.Value.Day,
                                                Int32.Parse(NUD_HeureFin.Value.ToString()),
                                                Int32.Parse(NUD_MinuteFin.Value.ToString()),
                                                0);
            }
        }

        private void NUD_HeureFin_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                DTP_Date.Value.Month,
                                                DTP_Date.Value.Day,
                                                Int32.Parse(NUD_HeureFin.Value.ToString()),
                                                Int32.Parse(NUD_MinuteFin.Value.ToString()),
                                                0);
            }
        }

        private void NUD_MinuteDebut_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                DTP_Date.Value.Month,
                                                DTP_Date.Value.Day,
                                                Int32.Parse(NUD_HeureDebut.Value.ToString()),
                                                Int32.Parse(NUD_MinuteDebut.Value.ToString()),
                                                0);
            }
        }

        private void NUD_HeureDebut_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                DTP_Date.Value.Month,
                                                DTP_Date.Value.Day,
                                                Int32.Parse(NUD_HeureDebut.Value.ToString()),
                                                Int32.Parse(NUD_MinuteDebut.Value.ToString()),
                                                0);
            }
        }

        private void DLG_Events_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PositionEvents = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
