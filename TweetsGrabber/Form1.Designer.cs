namespace TweetsGrabber
{
    partial class Form1
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
            this.GrabAction = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TUtextbox = new System.Windows.Forms.TextBox();
            this.Tweetslbl = new System.Windows.Forms.Label();
            this.ALLTWEETS = new System.Windows.Forms.CheckBox();
            this.KWtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GrabAction
            // 
            this.GrabAction.Location = new System.Drawing.Point(12, 119);
            this.GrabAction.Name = "GrabAction";
            this.GrabAction.Size = new System.Drawing.Size(75, 23);
            this.GrabAction.TabIndex = 0;
            this.GrabAction.Text = "Grab";
            this.GrabAction.UseVisualStyleBackColor = true;
            this.GrabAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(118, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(264, 305);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // TUtextbox
            // 
            this.TUtextbox.Location = new System.Drawing.Point(6, 12);
            this.TUtextbox.Name = "TUtextbox";
            this.TUtextbox.Size = new System.Drawing.Size(100, 20);
            this.TUtextbox.TabIndex = 2;
            this.TUtextbox.Text = "Username";
            // 
            // Tweetslbl
            // 
            this.Tweetslbl.AutoSize = true;
            this.Tweetslbl.Location = new System.Drawing.Point(3, 169);
            this.Tweetslbl.Name = "Tweetslbl";
            this.Tweetslbl.Size = new System.Drawing.Size(52, 13);
            this.Tweetslbl.TabIndex = 3;
            this.Tweetslbl.Text = "Tweet : 0";
            // 
            // ALLTWEETS
            // 
            this.ALLTWEETS.AutoSize = true;
            this.ALLTWEETS.Location = new System.Drawing.Point(12, 79);
            this.ALLTWEETS.Name = "ALLTWEETS";
            this.ALLTWEETS.Size = new System.Drawing.Size(94, 17);
            this.ALLTWEETS.TabIndex = 4;
            this.ALLTWEETS.Text = "ALL TWEETS";
            this.ALLTWEETS.UseVisualStyleBackColor = true;
            // 
            // KWtextbox
            // 
            this.KWtextbox.Location = new System.Drawing.Point(6, 38);
            this.KWtextbox.Name = "KWtextbox";
            this.KWtextbox.Size = new System.Drawing.Size(100, 20);
            this.KWtextbox.TabIndex = 5;
            this.KWtextbox.Text = "KeyWord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 329);
            this.Controls.Add(this.KWtextbox);
            this.Controls.Add(this.ALLTWEETS);
            this.Controls.Add(this.Tweetslbl);
            this.Controls.Add(this.TUtextbox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.GrabAction);
            this.Name = "Form1";
            this.Text = "Tweets Grabber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GrabAction;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox TUtextbox;
        private System.Windows.Forms.Label Tweetslbl;
        private System.Windows.Forms.CheckBox ALLTWEETS;
        private System.Windows.Forms.TextBox KWtextbox;
    }
}

