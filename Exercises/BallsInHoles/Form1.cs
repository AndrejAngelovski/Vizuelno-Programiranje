using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BallsInHoles
{
    public partial class Form1 : Form
    {
        BallsDoc ballsDoc;
        Color currentColor;
        //Timer timer;
        int leftX;
        int topY;
        int width;
        int height;

        private string FileName;
        
        public Form1()
        {
            InitializeComponent();
            ballsDoc = new BallsDoc();
            currentColor = Color.Red;
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            leftX = 20;
            topY = 60;
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);
            ballsDoc.GenerateHoles(leftX, topY, width, height);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ballsDoc.MoveBalls(leftX, topY, width, height);
            ballsDoc.CheckColisions();
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(pen, leftX, topY, width, height);
            pen.Dispose();
            ballsDoc.Draw(e.Graphics);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);
        }

        private void saveFile()
        {
            if(FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "BallsInHoles doc file (*.blh)|*.blh";
                saveFileDialog.Title = "Save balls doc";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if(FileName != null)
            {
                using(FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, ballsDoc);
                }
            }
        }

        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Balls file (*.bill)|*.bill";
            openFileDialog.Title = "Open balls doc file";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using(FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        ballsDoc = (BallsDoc)formatter.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ballsDoc.AddBall(new Ball(e.Location, currentColor));
            Invalidate(true);
        }

        private void toolStripLabelGenerate_Click(object sender, EventArgs e)
        {
            ballsDoc.GenerateHoles(leftX, topY, width, height);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballsDoc = new BallsDoc();
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("# Balls: {0}", ballsDoc.Balls.Count);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }
    }
}
