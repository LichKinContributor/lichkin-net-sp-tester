using LichKin.IO.Ports.Test;
using System;
using System.Windows.Forms;

namespace lichkin_net_sp_tester
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonFT02RL_Click(object sender, EventArgs e)
        {
            FT02RLForm FT02RLForm = new FT02RLForm();
            FT02RLForm.Show();
        }
    }
}
