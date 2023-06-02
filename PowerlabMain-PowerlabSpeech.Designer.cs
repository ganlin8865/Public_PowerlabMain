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
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(669, 259);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.emojimix_app_2_7;
            pictureBox1.Location = new System.Drawing.Point(458, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(75, 75);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(429, 111);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 12);
            label1.TabIndex = 2;
            label1.Text = "你好，我叫PowerSpeech！";
            // 
            // PowerlabMain_PowerlabSpeech
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 561);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "PowerlabMain_PowerlabSpeech";
            Text = "PowerlabSpeech语音助手";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}