namespace PowerlabMain
{
    partial class PowerlabMain_PowerlabLogin
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
            picLogo = new System.Windows.Forms.PictureBox();
            lblUserName = new System.Windows.Forms.Label();
            txtInput = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.powerlab;
            picLogo.Location = new System.Drawing.Point(300, 13);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(379, 193);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new System.Drawing.Font("途灵盈黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            lblUserName.Location = new System.Drawing.Point(300, 253);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(81, 30);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "用户名:";
            // 
            // txtInput
            // 
            txtInput.Font = new System.Drawing.Font("途灵盈黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            txtInput.Location = new System.Drawing.Point(387, 251);
            txtInput.Name = "txtInput";
            txtInput.Size = new System.Drawing.Size(292, 36);
            txtInput.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Font = new System.Drawing.Font("途灵盈黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            btnLogin.Location = new System.Drawing.Point(369, 476);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(244, 73);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "去测试PowerlabSpeech";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // PowerlabMain_PowerlabLogin
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(984, 561);
            Controls.Add(btnLogin);
            Controls.Add(txtInput);
            Controls.Add(lblUserName);
            Controls.Add(picLogo);
            MaximizeBox = false;
            Name = "PowerlabMain_PowerlabLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PowerlabMain_PowerlabLogin";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnLogin;
    }
}