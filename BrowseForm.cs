using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertPic
{
    public partial class BrowseForm : Form
    {
        Bitmap image;
        EventBuddy buddy;
        public BrowseForm()
        {
            InitializeComponent();
            normalButton.Hide();
            invertButton.Hide();
            specialButton.Hide();
            pictureBox1.Hide();
        }

        // Opens Directory to access specifically images:
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.jfif; *.png)|*.jpg; *.jpeg; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                textBox1.Text = open.FileName;
                image = new Bitmap(open.FileName);

                normalButton.Show();
                invertButton.Show();
                specialButton.Show();
                pictureBox1.Show();
            }

        }
        
        // Create New Art -- Open ArtForm:
        private void normalButton_Click(object sender, EventArgs e)
        {
            // -- Adds NORMAL art to album + Initialize Event Handler -- 
            this.Hide();
            Program.artAlbum[Program.count] = new Art(this.image);
            buddy = new EventBuddy(Program.artAlbum[Program.count]);
            Program.artAlbum[Program.count].displayForm();
            Program.count++;
            this.Close();
        }
        private void invertButton_Click(object sender, EventArgs e)
        {
            // -- Adds INVERTED art to album + Initialize Event Handler -- 
            this.Hide();
            Program.artAlbum[Program.count] = new Invert(this.image);
            buddy = new EventBuddy(Program.artAlbum[Program.count]);
            Program.artAlbum[Program.count].displayForm();
            Program.count++;
            this.Close();
        }
        private void specialButton_Click(object sender, EventArgs e)
        {
            // -- Adds SPECIAL art to album + Initialize Event Handler -- 
            this.Hide();
            Program.artAlbum[Program.count] = new Special(this.image);
            buddy = new EventBuddy(Program.artAlbum[Program.count]);
            Program.artAlbum[Program.count].displayForm();
            Program.count++;
            this.Close();
        }
    }
}
