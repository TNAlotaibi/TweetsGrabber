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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GrabAction
            // 
            this.GrabAction.BackColor = System.Drawing.Color.Black;
            this.GrabAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrabAction.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.GrabAction.Location = new System.Drawing.Point(195, 24);
            this.GrabAction.Name = "GrabAction";
            this.GrabAction.Size = new System.Drawing.Size(109, 23);
            this.GrabAction.TabIndex = 0;
            this.GrabAction.Text = "Grab";
            this.GrabAction.UseVisualStyleBackColor = false;
            this.GrabAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(2, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(323, 145);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // TUtextbox
            // 
            this.TUtextbox.BackColor = System.Drawing.Color.Black;
            this.TUtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TUtextbox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TUtextbox.Location = new System.Drawing.Point(6, 24);
            this.TUtextbox.Name = "TUtextbox";
            this.TUtextbox.Size = new System.Drawing.Size(179, 20);
            this.TUtextbox.TabIndex = 2;
            this.TUtextbox.Text = "Username";
            this.TUtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tweetslbl
            // 
            this.Tweetslbl.AutoSize = true;
            this.Tweetslbl.BackColor = System.Drawing.Color.Black;
            this.Tweetslbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Tweetslbl.Location = new System.Drawing.Point(-1, 225);
            this.Tweetslbl.Name = "Tweetslbl";
            this.Tweetslbl.Size = new System.Drawing.Size(52, 13);
            this.Tweetslbl.TabIndex = 3;
            this.Tweetslbl.Text = "Tweet : 0";
            // 
            // ALLTWEETS
            // 
            this.ALLTWEETS.AutoSize = true;
            this.ALLTWEETS.BackColor = System.Drawing.Color.Black;
            this.ALLTWEETS.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ALLTWEETS.Location = new System.Drawing.Point(196, 53);
            this.ALLTWEETS.Name = "ALLTWEETS";
            this.ALLTWEETS.Size = new System.Drawing.Size(71, 17);
            this.ALLTWEETS.TabIndex = 4;
            this.ALLTWEETS.Text = "All tweets";
            this.ALLTWEETS.UseVisualStyleBackColor = false;
            // 
            // KWtextbox
            // 
            this.KWtextbox.BackColor = System.Drawing.Color.Black;
            this.KWtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KWtextbox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.KWtextbox.Location = new System.Drawing.Point(6, 50);
            this.KWtextbox.Name = "KWtextbox";
            this.KWtextbox.Size = new System.Drawing.Size(179, 20);
            this.KWtextbox.TabIndex = 5;
            this.KWtextbox.Text = "Keyword";
            this.KWtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Twitter Grabber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(309, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(328, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KWtextbox);
            this.Controls.Add(this.ALLTWEETS);
            this.Controls.Add(this.Tweetslbl);
            this.Controls.Add(this.TUtextbox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.GrabAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

