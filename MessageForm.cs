using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConvertPic
{
    public partial class MessageForm : Form
    {
        // Constructor Method:
        public MessageForm()
        {
            InitializeComponent();
        }
        public MessageForm(string msg)
        {
            // -- Output message form with provided string --
            InitializeComponent();
            message.Text = msg;
        }

        // -- Closes form -- 
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
