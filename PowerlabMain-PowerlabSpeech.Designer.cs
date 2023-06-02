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
            btnSend = new System.Windows.Forms.Button();
            picSmileTitle = new System.Windows.Forms.PictureBox();
            lblNameTitle = new System.Windows.Forms.Label();
            lblQuestionTitle = new System.Windows.Forms.Label();
            txtInput = new System.Windows.Forms.TextBox();
            btnLssues = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)picSmileTitle).BeginInit();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackgroundImage = Properties.Resources.a141;
            btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSend.ForeColor = System.Drawing.Color.Transparent;
            btnSend.Location = new System.Drawing.Point(669, 207);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(48, 48);
            btnSend.TabIndex = 0;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += button1_Click;
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
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lblNameTitle.Location = new System.Drawing.Point(302, 98);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new System.Drawing.Size(384, 42);
            lblNameTitle.TabIndex = 2;
            lblNameTitle.Text = "你好,我叫PowerSpeech!";
            // 
            // lblQuestionTitle
            // 
            lblQuestionTitle.AutoSize = true;
            lblQuestionTitle.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblQuestionTitle.Location = new System.Drawing.Point(417, 142);
            lblQuestionTitle.Name = "lblQuestionTitle";
            lblQuestionTitle.Size = new System.Drawing.Size(161, 27);
            lblQuestionTitle.TabIndex = 3;
            lblQuestionTitle.Text = "你有什么问题吗?";
            // 
            // txtInput
            // 
            txtInput.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            txtInput.Location = new System.Drawing.Point(269, 207);
            txtInput.Name = "txtInput";
            txtInput.Size = new System.Drawing.Size(394, 46);
            txtInput.TabIndex = 4;
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
            // PowerlabMain_PowerlabSpeech
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 561);
            Controls.Add(btnLssues);
            Controls.Add(txtInput);
            Controls.Add(lblQuestionTitle);
            Controls.Add(lblNameTitle);
            Controls.Add(picSmileTitle);
            Controls.Add(btnSend);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "PowerlabMain_PowerlabSpeech";
            Text = "PowerlabSpeech语音助手";
            ((System.ComponentModel.ISupportInitialize)picSmileTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox picSmileTitle;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblQuestionTitle;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnLssues;
    }
}