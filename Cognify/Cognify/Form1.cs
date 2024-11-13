using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cognify
{
    public partial class Form1 : Form
    {
        private CognifyController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new CognifyController();
        }

        private void btnApplyRehabilitation_Click(object sender, EventArgs e)
        {
            string selectedCrime = cbCrimeType.SelectedItem?.ToString();
            if (selectedCrime != null)
            {
                string result = controller.ApplyRehabilitation(selectedCrime);
                MessageBox.Show(result, "Resultado");
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de crimen.", "Error");
            }
        }

        private void btnShowImpact_Click(object sender, EventArgs e)
        {
            string impactMessage = controller.ShowImpact();
            lblresult.Text = impactMessage;
        }
    }
}
