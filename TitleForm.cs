using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConvertPic
{
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        // Create New Art button - Opens Browse Form
        private void newButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BrowseForm help = new BrowseForm();
            help.ShowDialog();
            this.Show();
        }

        // Exit Application button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Album Open button - Opens Album Form
        private void albumButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AlbumForm album = new AlbumForm();
            album.ShowDialog();
            this.Show();
        }
    }
}
