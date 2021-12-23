using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;
using Discord_Webhook_Sender;

namespace Discord_WebHook_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void swh1(string URL, string msg, string username, string avatar)
        {
            http.Post(URL, new NameValueCollection()
            {
                { "avatar_url", avatar},
                { "username", username },
                { "content", msg }
            });
        }
        public static void swh2(string URL, string msg, string username)
        {
            http.Post(URL, new NameValueCollection()
            {
                { "username", username },
                { "content", msg }
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                swh1(textBox1.Text, string.Concat(new string[] { textBox4.Text }), textBox3.Text, textBox2.Text);
            }
            catch
            {
                swh2(textBox1.Text, string.Concat(new string[] { textBox4.Text }), textBox3.Text);
            }
        }
    }
}
