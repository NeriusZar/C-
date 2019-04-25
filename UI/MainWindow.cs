using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class MainWindow : Form
    {
       
        public MainWindow()
        {
           
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Settings.Default.MyColor;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addControl1.Visible = false;
            cameraControl1.Visible = false;
            homeControl1.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cameraControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addControl1.Visible = true;
            cameraControl1.Visible = false;
            homeControl1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addControl1.Visible = false;
            cameraControl1.Visible = true;
            homeControl1.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cameraControl1.CloseCamera();
            
        }

        private void addControl1_Load(object sender, EventArgs e)
        {
  
        }


        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Settings.Default.MyColor = colorDialog1.Color;
            Settings.Default.Save();
            BackColor = Settings.Default.MyColor;
        }

        private void addControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
