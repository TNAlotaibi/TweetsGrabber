using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TweetsGrabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TweetsCount = 0;
            var TargetUsername = TUtextbox.Text;
            var Keyword = KWtextbox.Text;
            Keyword = ALLTWEETS.Checked ? "*" : Keyword;
            IEnumerable<string> Tweets = Twitter.TweetsGenerator(TargetUsername, Keyword);
            if (Tweets.GetEnumerator().MoveNext())
            {
                richTextBox1.Clear();
                foreach (var Tweet in Tweets)
                {
                    if (isURL(Tweet))
                    {
                        File.AppendAllText("Media.txt", Tweet + Environment.NewLine);
                    }
                    Tweetslbl.Text = "Tweets : " + ++TweetsCount;
                    richTextBox1.AppendText(Tweet + Environment.NewLine);
                }
            }
            else MessageBox.Show("No tweets", "TweetsGrabber", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        bool isURL(string text)
        => Regex.Match(text, @"http(s)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?([a-zA-Z0-9\-\?\,\'\/\+&%\$#_]+)").Success;

        private void Form1_Load(object sender, EventArgs e)
        {
            Twitter.GetHeaders();
        }
    }
}
