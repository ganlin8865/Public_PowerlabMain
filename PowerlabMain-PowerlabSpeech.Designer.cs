namespace PowerlabMain
{
    partial class PowerlabMain_PowerlabSpeech
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerlabMain_PowerlabSpeech));
            btnSend = new System.Windows.Forms.Button();
            picSmileTitle = new System.Windows.Forms.PictureBox();
            lblQuestionTitle = new System.Windows.Forms.Label();
            txtQuestionInput = new System.Windows.Forms.TextBox();
            btnLssues = new System.Windows.Forms.Button();
            lblNameTitleChn = new System.Windows.Forms.Label();
            txtAnswer = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)picSmileTitle).BeginInit();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackgroundImage = Properties.Resources.a141;
            btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSend.ForeColor = System.Drawing.Color.Transparent;
            btnSend.Location = new System.Drawing.Point(675, 193);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(52, 52);
            btnSend.TabIndex = 0;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // picSmileTitle
            // 
            picSmileTitle.Image = Properties.Resources.emojimix_app_2_7;
            picSmileTitle.Location = new System.Drawing.Point(456, 12);
            picSmileTitle.Name = "picSmileTitle";
            picSmileTitle.Size = new System.Drawing.Size(80, 80);
            picSmileTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picSmileTitle.TabIndex = 1;
            picSmileTitle.TabStop = false;
            // 
            // lblQuestionTitle
            // 
            lblQuestionTitle.AutoSize = true;
            lblQuestionTitle.Font = new System.Drawing.Font("途灵盈黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblQuestionTitle.Location = new System.Drawing.Point(419, 142);
            lblQuestionTitle.Name = "lblQuestionTitle";
            lblQuestionTitle.Size = new System.Drawing.Size(163, 29);
            lblQuestionTitle.TabIndex = 3;
            lblQuestionTitle.Text = "你有什么问题吗?";
            // 
            // txtQuestionInput
            // 
            txtQuestionInput.Font = new System.Drawing.Font("途灵盈黑", 21.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtQuestionInput.Location = new System.Drawing.Point(274, 193);
            txtQuestionInput.Name = "txtQuestionInput";
            txtQuestionInput.Size = new System.Drawing.Size(394, 49);
            txtQuestionInput.TabIndex = 4;
            // 
            // btnLssues
            // 
            btnLssues.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnLssues.Location = new System.Drawing.Point(12, 504);
            btnLssues.Name = "btnLssues";
            btnLssues.Size = new System.Drawing.Size(130, 45);
            btnLssues.TabIndex = 5;
            btnLssues.Text = "反馈";
            btnLssues.UseVisualStyleBackColor = true;
            // 
            // lblNameTitleChn
            // 
            lblNameTitleChn.AutoSize = true;
            lblNameTitleChn.Font = new System.Drawing.Font("途灵盈黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblNameTitleChn.Location = new System.Drawing.Point(298, 96);
            lblNameTitleChn.Name = "lblNameTitleChn";
            lblNameTitleChn.Size = new System.Drawing.Size(401, 46);
            lblNameTitleChn.TabIndex = 6;
            lblNameTitleChn.Text = "你好,我叫PowerSpeech!";
            // 
            // txtAnswer
            // 
            txtAnswer.AcceptsReturn = true;
            txtAnswer.Font = new System.Drawing.Font("途灵盈黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            txtAnswer.Location = new System.Drawing.Point(160, 251);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            txtAnswer.Size = new System.Drawing.Size(676, 212);
            txtAnswer.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("途灵盈黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(333, 475);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(332, 23);
            label1.TabIndex = 8;
            label1.Text = "小提示:可以说”更改语音“来更改朗读的声音。";
            // 
            // PowerlabMain_PowerlabSpeech
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(984, 561);
            Controls.Add(label1);
            Controls.Add(txtAnswer);
            Controls.Add(lblNameTitleChn);
            Controls.Add(btnLssues);
            Controls.Add(txtQuestionInput);
            Controls.Add(lblQuestionTitle);
            Controls.Add(picSmileTitle);
            Controls.Add(btnSend);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            Name = "PowerlabMain_PowerlabSpeech";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PowerSpeech语音助手";
            ((System.ComponentModel.ISupportInitialize)picSmileTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox picSmileTitle;
        private System.Windows.Forms.Label lblQuestionTitle;
        private System.Windows.Forms.TextBox txtQuestionInput;
        private System.Windows.Forms.Button btnLssues;
        private System.Windows.Forms.Label lblNameTitleChn;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label1;
    }
}