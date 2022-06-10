using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using static System.Console;

namespace ConvertPic
{
    static class Program
    {
        // Public Fields accessible anywhere 
        public static Art[] artAlbum = new Art[99]; // Album
        public static int count = 0;                // Album counter

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TitleForm title = new TitleForm();
            Application.Run(title);
        }
    }

    // Base ART class:
    // Event handler for Art object changes
    public delegate void Art_Changed(object sender, EventArgs e);
    public class Art : IComparable
    {
        // Private and Public Fields:
        private Bitmap imageArt;
        private string asciiArt;
        private string title;
        private string author;
        private string style;
        private int index;
        // ------------------------------
        public ArtForm artForm;
        public event Art_Changed Changed;
        public Bitmap ImageArt { get { return imageArt; } set { imageArt = value; } }
        public string AsciiArt { get { return asciiArt; } set { asciiArt = value; } }
        public string Title { get { return title; } 
                              set { title = value; OnChanged(EventArgs.Empty); } }
        public string Author { get { return author; } 
                               set { author = value; } }
        public int Index { get { return index; } set { index = value; } }
        public string Style { get { return style; } set { style = value; } }
        // ------------------------------

        // Constructor Methods:
        public Art() { }
        public Art(Bitmap image)
        {
            ImageArt = imageCrop(image);
            ImageArt = imageResize(ImageArt);
            AsciiArt = imageConvert(ImageArt);
            Index = Program.count;
            Style = "Normal";
        }

        // Image Alteration Methods:
        public Bitmap imageCrop(Bitmap img)
        {
            Bitmap imgCrop;
            Rectangle x;
            int b;
            // -- Sets height and width equal to smaller of the two dimensions --
            if (img.Width > img.Height)
            {
                b = (int)Math.Floor((img.Width - img.Height) / 2.0);
                x = new Rectangle(b, 0, img.Height, img.Height);
            }
            else
            {
                b = (int)Math.Floor((img.Height - img.Width) / 2.0);
                x = new Rectangle(0, b, img.Width, img.Width);
            }
            
            imgCrop = img.Clone(x, img.PixelFormat);
            return imgCrop;
        }
        public Bitmap imageResize(Bitmap image)
        {
            int x = 128;
            Bitmap imgSize = new Bitmap(x, x);
            Graphics g = Graphics.FromImage((Image)imgSize);
            // -- Resizes Bitmap images to a common dimension of 128x128 --
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, x, x);
            g.Dispose();
            
            return imgSize;
        }
        // -- Virtual method 
        public virtual string imageConvert(Bitmap image)
        {
            string[] asciiChar = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", "\u00A0" };
            Color color, greyScale;
            int rgb, index;
            StringBuilder sb = new StringBuilder();
            // -- Converts Bitmap image into a stylized ASCII string --
            for (double h = 0; h < image.Height; h += 1.75)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    color = image.GetPixel(w, (int)h);
                    rgb = (color.R + color.G + color.B) / 3;
                    greyScale = Color.FromArgb(rgb, rgb, rgb);
                    index = (greyScale.R * 10) / 255;
                    
                    if (w == image.Width - 1)
                        sb.AppendLine(asciiChar[index]);
                    else
                    {
                        sb.Append(asciiChar[index]);
                    }
                }
            }
            return sb.ToString();
        }

        // Additional Methods:
        public void displayForm()
        {
            // Displays ArtForm
            artForm = new ArtForm(ImageArt, AsciiArt, Title, Author, Style, Index);
            artForm.ShowDialog();
        }
        public override string ToString()
        {
            // Writes all fields to label
            return "Title: " + Title + "\n" + "Auhtor: " + Author + "\n" + "Style: " 
                    + Style + "\n" + "Index: " + Index.ToString();
        }
        public int CompareTo(Object o)
        {
            // Interface method to allow use of Array.Sort methods
            if (this.Title.CompareTo(((Art)o).Title) == -1)
                return 1;
            else if (this.Title.CompareTo(((Art)o).Title) == 1)
                return -1;
            else
                return 0;
        }
        private void OnChanged(EventArgs e)
        {
            // Event handler on changed title information
            Changed(this, e);
        }
    }

    // Derived classes:
    public class Invert : Art
    {
        // Constructor Method:
        public Invert (Bitmap image) : base(image) 
        {
            Style = "Inverted";
        }
        
        // Overridden Image Alteration Method:
        public override string imageConvert(Bitmap image)
        {
            string[] asciiChar = { "\u00A0", ".", "-", ":", "*", "+", "=", "%", "@", "#", "#" };
            Color color, greyScale;
            int rgb, index;
            StringBuilder sb = new StringBuilder();
            // -- Similar structure as base with different effect --
            for (double h = 0; h < image.Height; h += 1.75)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    color = image.GetPixel(w, (int)h);
                    rgb = (color.R + color.G + color.B) / 3;
                    greyScale = Color.FromArgb(rgb, rgb, rgb);
                    index = (greyScale.R * 10) / 255;
                    
                    if (w == image.Width - 1)
                        sb.AppendLine(asciiChar[index]);
                    else
                    {
                        sb.Append(asciiChar[index]);
                    }
                }
            }
            return sb.ToString();
        }
        // Overridden ToString Method:
        public override string ToString()
        {
            return "Title: " + Title + "\n" + "Auhtor: " + Author + "\n" + "Style: " 
                    + Style + "\n" + "Index: " + Index.ToString();
        }

    }
    public class Special : Art
    {
        // Constructor Method:
        public Special(Bitmap image) : base(image) 
        {
            Style = "Special";
        }

        // Overidden Image Alteration Method:
        public override string imageConvert(Bitmap image)
        {
            string[] asciiChar = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", "\u00A0" };
            Color color, greyScale;
            int rgb, index;
            StringBuilder sb = new StringBuilder();
            // -- Same as before -- 
            for (double w = 0; w < image.Width; w += 1.75)
            {
                for (int h = 0; h < image.Height; h++)
                {
                    color = image.GetPixel((int)w, h);
                    rgb = (color.R + color.G + color.B) / 3;
                    greyScale = Color.FromArgb(rgb, rgb, rgb);
                    index = (greyScale.R * 10) / 255;
                    
                    if (h == image.Height - 1)
                        sb.AppendLine(asciiChar[index]);
                    else
                    {
                        sb.Append(asciiChar[index]);
                    }
                }
            }
            return sb.ToString();
        }

        // Overridden ToString Method:
        public override string ToString()
        {
            return "Title: " + Title + "\n" + "Auhtor: " + Author + "\n" + "Style: " + Style + "\n" + "Index: " + Index.ToString();
        }

    }

    // Customized Event Handeler:
    class EventBuddy
    {
        // -- New event when Art.Title has changed -- 
        private Art art;
        public EventBuddy(Art art)
        {
            this.art = art;
            this.art.Changed += new Art_Changed(Buddy);
        }
        private void Buddy (object sender, EventArgs e)
        {
            // -- New message dialogue when event occurs -- 
            MessageForm message = new MessageForm("Art title changed to: " + art.Title + "!");
            message.ShowDialog();
        }
    }
}
