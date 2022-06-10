using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConvertPic
{
    public partial class ArtForm : Form
    {
        private int index;
        
        // Constructor Methods:
        public ArtForm()
        {
            InitializeComponent();
        }
        public ArtForm(Bitmap image, string art, string title, string author, string style, int index)
        {
            InitializeComponent();
            textBox1.Hide();
            textBox2.Hide();
            saveButton.Hide();
          
            pictureBox1.Image = image;
            label2.Text = art;
            label6.Text = title;
            label7.Text = author;
            label8.Text = style;
            label9.Text = index.ToString();
            textBox1.Text = title;
            textBox2.Text = author;
            
            this.index = index;
        }

        // Button Methods:
        private void backButton_Click(object sender, EventArgs e)
        {
            // -- Closes current form --
            this.Close();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            // -- Opens the text input --
            textBox1.Show();
            textBox2.Show();
            saveButton.Show();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            // -- Saves the inputted text + Event handler goes off --
            Program.artAlbum[index].Title = textBox1.Text;
            Program.artAlbum[index].Author = textBox2.Text;
            label6.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            
            textBox1.Hide();
            textBox2.Hide();
            saveButton.Hide();
        }
    }
}
