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
using System.Speech.Recognition;

namespace PowerlabMain
{
    public partial class PowerlabMain_PowerlabSpeech : Form
    {
        string Question, Answer;

        public PowerlabMain_PowerlabSpeech()
        {
            InitializeComponent();
        }

        public bool IsHello(string question)
        {
            if (question.Contains("你好") == true 
                || question.Contains("您好") == true
                || question.Contains("PowerSpeech好") == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            //非常高兴与您交流！您好！我是PowerSpeech，您需要我帮您做些什么吗？
        }

        public bool IsName(string question)
        {
            if (question.Contains("你叫什么名字") == true
                || question.Contains("你叫什么") == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsWho(string question)
        {
            if (question.Contains("你是谁") == true)
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
                string WhoAnswer = "非常高兴见到您！\n我是PowerSpeech，由Powerlab团队开发的人工智能语音系统。\n有什么我可以帮您的吗？";
                return WhoAnswer;
            }
            else if (IsName(question))
            {
                string WhoAnswer = "我非常高兴您对我的名字感兴趣！\n我的名字是PowerSpeech，由Powerlab公司开发的人工智能语音系统。\n有什么我可以帮您的吗？";
                return WhoAnswer;
            }
            else if (IsHello(question))
            {
                string WhoAnswer = "我非常高兴您对我的名字感兴趣！\n我的名字是PowerSpeech，由Powerlab公司开发的人工智能语音系统。\n有什么我可以帮您的吗？";
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
            Answer = Choose(Question);
            txtAnswer.Text = Answer;
            speechSynthesizer.SpeakAsync(Answer);
        }

        private void txtQuestionInput_TextChanged(object sender, EventArgs e)
        {
            Question = this.Text;
        }
    }
}
