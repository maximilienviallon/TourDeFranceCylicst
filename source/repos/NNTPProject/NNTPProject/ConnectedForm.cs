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
    public partial class ConnectedForm : Form
    {
        private SocketClient sc = new SocketClient();
        public ConnectedForm()
        {
            InitializeComponent();
        }

        private void ConnectedForm_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            


            foreach (string list in sc.GetNewsGroup())
            {
                StringBuilder sb = new StringBuilder();
                
                foreach (char letters in list)
                {
                    
                    if(!char.IsNumber(letters) && !char.IsWhiteSpace(letters) )
                    {   
                        
                        sb.Append(letters);
                        
                    }
                }
                sb.Remove(sb.Length - 1, 1);
                listView1.Items.Add(sb.ToString());
        
            }
            Console.WriteLine("potaot?");
         
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            foreach (string body in sc.GetBody())
            {
                listView3.Items.Add(body);
            }
            Console.WriteLine("!potato!");
        }
    }
}
