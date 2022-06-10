using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ConvertPic
{
    public partial class AlbumForm : Form
    {
        // Initial Fields - Methods: 
        private int anchor;
        EventBuddy buddy;
        public AlbumForm()
        {
            InitializeComponent();
            anchor = 0;
            display1(anchor);
            display2(anchor+1);
            display3(anchor+2);
        }

        // Display methods:
        private void display1(int x)
        {
            // -- Shows all relevant information --
            if (Program.artAlbum[x] == null)
            {
                view1.Hide();
                delete1.Hide();
                pictureBox1.Image = null;
                label1.Text = "NONE";
            }
            else
            {
                view1.Show();
                delete1.Show();
                pictureBox1.Image = Program.artAlbum[x].ImageArt;
                label1.Text = Program.artAlbum[x].ToString();
            }
           
        }
        private void display2(int x)
        {
            // -- Shows all relevant information --
            if (Program.artAlbum[x] == null)
            {
                view2.Hide();
                delete2.Hide();
                pictureBox2.Image = null;
                label2.Text = "NONE";
            }
            else
            {
                view2.Show();
                delete2.Show();
                pictureBox2.Image = Program.artAlbum[x].ImageArt;
                label2.Text = Program.artAlbum[x].ToString();
            }

        }
        private void display3(int x)
        {
            // -- Shows all relevant information --
            if (Program.artAlbum[x] == null)
            {
                view3.Hide();
                delete3.Hide();
                pictureBox3.Image = null;
                label3.Text = "NONE";
            }
            else
            {
                view3.Show();
                delete3.Show();
                pictureBox3.Image = Program.artAlbum[x].ImageArt;
                label3.Text = Program.artAlbum[x].ToString();
            }
           
        }

        // View/Delete methods:
        private void view1_Click(object sender, EventArgs e)
        {
            // -- Open associated ArtForm --
            this.Hide();
            Program.artAlbum[anchor].displayForm();
            display1(anchor);
            this.Show();
        }
        private void view2_Click(object sender, EventArgs e)
        {
            // -- Open associated ArtForm --
            this.Hide();
            Program.artAlbum[anchor+1].displayForm();
            display2(anchor + 1);
            this.Show();
        }
        private void view3_Click(object sender, EventArgs e)
        {
            // -- Open associated ArtForm --
            this.Hide();
            Program.artAlbum[anchor+2].displayForm();
            display3(anchor + 2);
            this.Show();
        }
        private void delete1_Click(object sender, EventArgs e)
        {
            MessageForm msg;
            int point = 0;
            int count = Program.count - 1;
            // -- Deletes associated ArtForm -- 
            for (int i = point; i < count; i++)
            {
                Program.artAlbum[i] = Program.artAlbum[i + 1];
                Program.artAlbum[i].Index = i;
            }
            Program.count -= 1;
            Program.artAlbum[count] = null;
            msg = new MessageForm("Successfully Deleted!");
            msg.ShowDialog();
            display1(anchor);
            display2(anchor + 1);
            display3(anchor + 2);
        }
        private void delete2_Click(object sender, EventArgs e)
        {
            MessageForm msg;
            int point = 1;
            int count = Program.count - 1;
            // -- Deletes associated ArtForm -- 
            for (int i = point; i < count; i++)
            {
                Program.artAlbum[i] = Program.artAlbum[i + 1];
                Program.artAlbum[i].Index = i;
            }
            Program.count -= 1;
            Program.artAlbum[count] = null;
            msg = new MessageForm("Successfully Deleted!");
            msg.ShowDialog();
            display2(anchor + 1);
            display3(anchor + 2);
        }
        private void delete3_Click(object sender, EventArgs e)
        {
            MessageForm msg;
            int point = 2;
            int count = Program.count - 1;
            // -- Deletes associated ArtForm -- 
            for (int i = point; i < count; i++)
            {
                Program.artAlbum[i] = Program.artAlbum[i + 1];
                Program.artAlbum[i].Index = i;
            }
            Program.count -= 1;
            Program.artAlbum[count] = null;
            msg = new MessageForm("Successfully Deleted!");
            msg.ShowDialog();
            display3(anchor + 2);
        }

        // Button Methods:
        private void exitButton_Click(object sender, EventArgs e)
        {
            // -- Closes form - Return to title --
            this.Close();
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            // -- Sorts Album array in alphabetical order --
            MessageForm message;
            Array.Sort(Program.artAlbum);
            Array.Reverse(Program.artAlbum, 0, Program.artAlbum.Length);
            message = new MessageForm("Successfully Sorted!");
            message.ShowDialog();
            
            display1(anchor);
            display2(anchor + 1);
            display3(anchor + 2);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream outFile;
            StreamWriter writer;
            MessageForm message;
            outFile = new FileStream("AlbumArt.txt", FileMode.Create, FileAccess.Write);
            writer = new StreamWriter(outFile);
            // -- Writes Album text into file 'AlbumArt.txt' --
            try
            {
                for (int i = 0; i < Program.artAlbum.Length; i++)
                {
                    if (Program.artAlbum[i] != null)
                    {
                        writer.Write(Program.artAlbum[i].AsciiArt);
                        writer.WriteLine(Program.artAlbum[i].Title);
                        writer.WriteLine(Program.artAlbum[i].Author);
                        writer.WriteLine(Program.artAlbum[i].Style);
                    }
                }
            }
            catch (IOException ex)
            {
                message = new MessageForm(ex.Message);
            }
            finally
            {
                // -- Ensures the file stream is closed properly -- 
                writer.Close();
                outFile.Close();
                message = new MessageForm("Successfully Saved!");
                message.ShowDialog();
            }
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            FileStream inFile;
            StreamReader reader;
            MessageForm message;
            Art art;
            string fileName = "AlbumArt.txt";
            
            StringBuilder sb;
            int count;
            // -- Reads from text file_ input into Album array --
            if(File.Exists(fileName))
            {
                inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                sb = new StringBuilder();
                count = File.ReadAllLines(fileName).Length;
                count = count / 77;
                try
                {
                    for (int i = 0; i < count; i++)
                    {
                        art = new Art();
                        buddy = new EventBuddy(art);
                        for (int j = 0; j < 74; j++)
                            sb.AppendLine(reader.ReadLine());
                        art.AsciiArt = sb.ToString();
                        art.Title = reader.ReadLine();
                        art.Author = reader.ReadLine();
                        art.Style = reader.ReadLine(); ;
                        art.Index = i;
                        Program.artAlbum[i] = art;
                        
                        sb.Clear();
                        Program.count = i + 1;
                    }
                }
                catch (IOException ex)
                {
                    message = new MessageForm(ex.Message);
                }
                finally
                {
                    // -- Ensures the file stream is closed properly -- 
                    reader.Close();
                    inFile.Close();
                    message = new MessageForm("Successfully Loaded!");
                    message.ShowDialog();
                    display1(anchor);
                    display2(anchor + 1);
                    display3(anchor + 2);
                }
            }
            else
            {
                // -- If no Album text is available -- 
                message = new MessageForm("No Album Available!");
                message.ShowDialog();
            }

        }
        private void leftButton_Click(object sender, EventArgs e)
        {
            // -- Moves page to the left by three positions --
            if (anchor != 0)
            {
                anchor -= 3;
                display1(anchor);
                display2(anchor + 1);
                display3(anchor + 2);
            }
        }
        private void rightButton_Click(object sender, EventArgs e)
        {
            // -- Moves page to the right by three positions -- 
            if (anchor < 97)
            {
                anchor += 3;
                display1(anchor);
                display2(anchor + 1);
                display3(anchor + 2);
            }
        }
    }

}
