using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Media;

namespace UI.UserControls
{
    public partial class CameraControl : UserControl
    {
        
        private int ImageCount = 0;
        Camera cam = new Camera();
        public CameraControl()
        {
            
            InitializeComponent();
            GetInfo();
            cam.OnFrameArrived += delegate(object source, FrameArrivedEventArgs e) {
                Image img = e.GetFrame();
                pictureBox1.Image = img;
            };
            
           

        }
        
        private void GetInfo()
        {
            var cameraDevices = cam.GetCameraSources();
            var cameraResolutions = cam.GetSupportedResolutions();
            foreach (var device in cameraDevices)
            {
                cmbCameraDevices.Items.Add(device);
            }
            foreach (var resolution in cameraResolutions)
            {
                cmdCameraResolutions.Items.Add(resolution);
            }
            cmbCameraDevices.SelectedIndex = 0;
            cmdCameraResolutions.SelectedIndex = 0;
        }
        
        
        private void cmdCameraResolutions_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cam.Start(cmdCameraResolutions.SelectedIndex);
        }

        private void cmbCameraDevices_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cam.ChangeCamera(cmbCameraDevices.SelectedIndex);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            string filename = Application.StartupPath + @"\" + "Image" + ImageCount.ToString();
            cam.Capture(filename);
            ImageCount++;
            MessageBox.Show("Your photo has been saved");
        }

        private void CameraControl_VisibleChanged(object sender, EventArgs e)
        {
                if(!this.Visible)
                {
                    cam.Stop();
                    pictureBox1.Image = null;
                }
            else { cam.Start(cmdCameraResolutions.SelectedIndex); }
        }
        public void CloseCamera()
        {
            cam.Stop();
        }



        
    }
}
