using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerlabMain
{
    public partial class PowerlabMain_PowerlabLogin : Form
    {
        public PowerlabMain_PowerlabLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PowerlabMain_PowerlabSpeech powerlabMain_PowerlabSpeech = new PowerlabMain_PowerlabSpeech();
            powerlabMain_PowerlabSpeech.Show();
        }
    }
}
