using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNTPProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SocketClient sc = new SocketClient();

            string url = textBox3.Text;
            int port = Int32.Parse(textBox4.Text);

            sc.Connect(url,port);
            string username = textbox1.Text;
            string password = textBox2.Text;
            sc.UserConnect(username,password);
            ConnectedForm something = new ConnectedForm();
            something.Activate();
            something.Show();
        }
    }
}
