using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licture6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Photo1.AllowDrop = Photo2.AllowDrop = true;     // A control attribute that allows drag and drop
        }

        private void OpenB_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                Photo1.Image = Bitmap.FromFile(OFD.FileName);
                CopyB.Enabled = FrameB.Enabled = true;
            }
        }

        private void CopyB_Click(object sender, EventArgs e)
        {
            if(Photo1.Image != null)
            {
                Clipboard.SetImage(Photo1.Image);   // Copy image to the clipborad
                PasteB.Enabled = true;
            }
        }

        private void PasteB_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Photo2.Image = Clipboard.GetImage();    // Get the image from the clipboard
                PasteB.Enabled = false;
            }
        }

        private void Photo1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Photo1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);

            if(data != null)
            {
                var filename = data as string[];
                if (filename.Length > 0)
                {
                    Photo1.Image = Bitmap.FromFile(filename[0]);
                    CopyB.Enabled = FrameB.Enabled = (FrameB.Enabled == false) ? true : false;
                }
            }
        }

        private void Photo2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Photo1.Image != null)
            {
                if (DoDragDrop(Photo1.Image, DragDropEffects.Move) == DragDropEffects.Move)
                    Photo1.Image = null;
            }
        }

        private void Photo2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) e.Effect = DragDropEffects.Move;
            else e.Effect = DragDropEffects.None;
        }

        private void Photo2_DragDrop(object sender, DragEventArgs e)
        {
            Photo2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            CopyB.Enabled = PasteB.Enabled = FrameB.Enabled = false;
        }

        private void FrameB_Click(object sender, EventArgs e)
        {
            if (Photo1.Image != null)
            {
                Bitmap image = (Bitmap)Photo1.Image;        // Store original iamge
                Bitmap layer = (Bitmap)Image.FromFile("frame.png");     // Store the frame
                Bitmap FinalImage = new Bitmap(image.Width, image.Height);  /* Create new empty image having same 
                                                                               height and width of original image*/
                using (Graphics graph = Graphics.FromImage(FinalImage))     // Create a graphics object to draw
                {                                                           // the two images as one 
                    graph.DrawImage(image, 0, 0, image.Width, image.Height);    // draw the original image in the image
                    graph.DrawImage(layer, 0, 0, image.Width, image.Height);    // draw the frame in the new image with size of original image
                }
                Photo1.Image = FinalImage;  // Insert the new image instead of the original one
            }
        }

        private void ScreenShotB_Click(object sender, EventArgs e)
        {
            this.Hide();        //Hide the screen of the program
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");   // a keyboad shortcut(sendkey) to take a screenshot and save it in the clipboard
            Photo1.Image = (Image)Clipboard.GetImage();      // Get tht screen shot form clipboard Insert the screenshot in the picturebox
            this.Show();            // Show program window
            
            
            /*
            // Another method to take a screenshot
            // Create a new empty image with size of device screen
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            Photo1.Image = bitmap;
            this.Show();
            */
        }
    }
}