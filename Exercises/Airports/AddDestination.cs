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
    public partial class AddDestination : Form
    {
        public Destination Destination { get; set; }
        public AddDestination()
        {
            InitializeComponent();
        }

        private void tbDestName_Validating(object sender, CancelEventArgs e)
        {
            if(tbDestName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbDestName, "");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDestName, null);
                e.Cancel = false;
            }
        }

        private void btnDestAdd_Click(object sender, EventArgs e)
        {
            Destination = new Destination(tbDestName.Text.Trim(), (int)nudDestDistance.Value, (int)nudDestPrice.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
