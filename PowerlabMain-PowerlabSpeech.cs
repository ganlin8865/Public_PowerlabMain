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
            if (question.Contains("你是谁") == true ||
                question.Contains("你是谁？") == true ||
                question.Contains("你是谁?") == true)
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
                string WhoAnswer = "您好！\n我是由Powerlab开发团队开发的名为\"PowerSpeech\"的语音助手1.0。\n我有什么能帮助你的吗？";
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
            txtAnswer.Text = Answer;
            speechSynthesizer.SpeakAsync(Answer);
        }
    }
}
