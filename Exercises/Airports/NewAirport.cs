using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class NewAirport : Form
    {
        public Airport Airport { get; set; }
        public NewAirport()
        {
            InitializeComponent();
        }

        private void tbAirportCity_Validating(object sender, CancelEventArgs e)
        {
            if(tbAirportCity.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbAirportCity, "Името на градот е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbAirportCity, null);
                e.Cancel = false;
            }
        }

        private void tbAirportName_Validating(object sender, CancelEventArgs e)
        {
            if(tbAirportName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbAirportName, "Името на аеродромот е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbAirportName, null);
                e.Cancel = false;
            }
        }

        private void btnAirportSave_Click(object sender, EventArgs e)
        {
            Airport = new Airport(tbAirportCity.Text.Trim(), tbAirportName.Text.Trim(), tbAirportShortcut.Text.Trim());
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void tbAirportShortcut_Validating(object sender, CancelEventArgs e)
        {
            if(tbAirportShortcut.Text.Trim().Length != 3)
            {
                errorProvider1.SetError(tbAirportShortcut, "Кратенката мора да биде точно 3 големи букви");
                e.Cancel = true;
            }
            else
            {
                string sh = tbAirportShortcut.Text.Trim();
                foreach(Char c in sh)
                {
                    if (Char.IsLower(c))
                    {
                        errorProvider1.SetError(tbAirportShortcut, "Кратенката мора да биде точно 3 големи букви");
                        e.Cancel = true;
                    }
                }
            }
            errorProvider1.SetError(tbAirportShortcut, null);
            e.Cancel = false;
        }

        private void btnAirportCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
