using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDetector
{
    public partial class MainWIndow : Form
    {
        public MainWIndow()
        {
            InitializeComponent();

            initTabControl();
        }

        void initTabControl()
        {
            tabControl.TabPages.Clear();
        }

        void addTabPage(string pageName, PictureBox pictureBox)
        {
            TabPage tabPage = new TabPage(pageName);
            tabPage.Controls.Add(pictureBox);
            tabControl.TabPages.Add(tabPage);
        }
       
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Open...";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(640, 480);

                pictureBox.Image = new Bitmap(openFileDialog.FileName);
                addTabPage(openFileDialog.FileName, pictureBox);
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Open...";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(640, 480);

                pictureBox.Image = new Bitmap(openFileDialog.FileName);
                addTabPage(openFileDialog.FileName, pictureBox);

                
            }
        }
    }
}
