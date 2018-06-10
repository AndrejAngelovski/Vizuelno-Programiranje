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

namespace HalfCircles
{
    public partial class Form1 : Form
    {
        private CircleDoc CircleDoc;
        Color Color;
        bool isStarted;
        string FileName;
        
        public Form1()
        {
            InitializeComponent();
            CircleDoc = new CircleDoc();
            Color = Color.Red;
            DoubleBuffered = true;
            isStarted = false;
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);
            isStarted = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CircleDoc.Pulse();
            Invalidate(true);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CircleDoc.AddCircle(e.Location, Color);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            CircleDoc.Draw(e.Graphics);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            isStarted = !isStarted;
            if (isStarted)
            {
                toolStripLabel1.Text = "Стоп";
                timer.Start();
            }
            else
            {
               toolStripLabel1.Text = "Старт";
                timer.Stop();
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Color = cd.Color;
            }
        }

        private void saveFile()
        {
            if(FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "HalfCircles doc file (*.hcd)|*.hcd";
                saveFileDialog.Title = "Save HalfCircles doc";
                saveFileDialog.FileName = FileName;
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if(FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, CircleDoc);
                }
            }
        }

        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HalfCircles doc file (*.hcd)|*.hcd";
            openFileDialog.Title = "Open circles doc file";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        CircleDoc = (CircleDoc)formatter.Deserialize(fileStream);
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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            CircleDoc = new CircleDoc();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Total: {0}", CircleDoc.Circles.Count);
        }
    }
}
