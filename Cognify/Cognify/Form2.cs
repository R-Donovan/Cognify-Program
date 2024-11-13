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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnSetenciaFisica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion de sentencia fisica");
        }

        private void btnRehabilitation_Click(object sender, EventArgs e)
        {
            Form1 formCognify = new Form1();
            formCognify.Show();
            this.Hide();
        }
    }
}
