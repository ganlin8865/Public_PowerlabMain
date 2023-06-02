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
using System.Globalization;

namespace PowerlabMain
{
    public partial class PowerlabMain_PowerlabSpeech : Form
    {
        string Question, Answer;

        public PowerlabMain_PowerlabSpeech()
        {
            InitializeComponent();
        }

        public bool IsWho(string question)
        {
            if (question == "你是谁" ||
                question == "你是谁？" ||
                question == "你是谁?")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Choose(string question)
        {
            if (IsWho(question))
            {
                string WhoAnswer = "我是由Powerlab开发团队开发的名为\"PowerSpeech\"的语音助手1.0，\n目前处于内测阶段，\n无法进行语音识别功能。";
                return WhoAnswer;
            }
            else
            {
                return question;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child, 0, new CultureInfo("zh-HANS"));
            Question = txtQuestionInput.Text;
            Answer = Choose(Question);
            txtAnswer.Text = speechSynthesizer.GetInstalledVoices().ToString();
            speechSynthesizer.Speak(Answer);
        }
    }
}
