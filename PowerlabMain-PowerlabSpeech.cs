using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace PowerlabMain
{
    public partial class PowerlabMain_PowerlabSpeech : Form
    {
        public PowerlabMain_PowerlabSpeech()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak("我逼逼逼逼逼逼逼逼逼逼逼逼逼逼逼逼逼逼逼逼逼逼");
        }
    }
}
