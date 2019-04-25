namespace UI.UserControls
{
    partial class CameraControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.savebutton = new System.Windows.Forms.Button();
            this.cameraDevicesLabel = new System.Windows.Forms.Label();
            this.resolutionsLabel = new System.Windows.Forms.Label();
            this.cmbCameraDevices = new System.Windows.Forms.ComboBox();
            this.cmdCameraResolutions = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.savebutton);
            this.panel1.Controls.Add(this.cameraDevicesLabel);
            this.panel1.Controls.Add(this.resolutionsLabel);
            this.panel1.Controls.Add(this.cmbCameraDevices);
            this.panel1.Controls.Add(this.cmdCameraResolutions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 112);
            this.panel1.TabIndex = 0;
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.SystemColors.Control;
            this.savebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.savebutton.Location = new System.Drawing.Point(533, 28);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(134, 60);
            this.savebutton.TabIndex = 4;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cameraDevicesLabel
            // 
            this.cameraDevicesLabel.AutoSize = true;
            this.cameraDevicesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.cameraDevicesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.cameraDevicesLabel.Location = new System.Drawing.Point(217, 27);
            this.cameraDevicesLabel.Name = "cameraDevicesLabel";
            this.cameraDevicesLabel.Size = new System.Drawing.Size(175, 23);
            this.cameraDevicesLabel.TabIndex = 3;
            this.cameraDevicesLabel.Text = "Camera devices";
            // 
            // resolutionsLabel
            // 
            this.resolutionsLabel.AutoSize = true;
            this.resolutionsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.resolutionsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.resolutionsLabel.Location = new System.Drawing.Point(34, 27);
            this.resolutionsLabel.Name = "resolutionsLabel";
            this.resolutionsLabel.Size = new System.Drawing.Size(116, 23);
            this.resolutionsLabel.TabIndex = 2;
            this.resolutionsLabel.Text = "Resolutions";
            // 
            // cmbCameraDevices
            // 
            this.cmbCameraDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.cmbCameraDevices.ForeColor = System.Drawing.SystemColors.Control;
            this.cmbCameraDevices.FormattingEnabled = true;
            this.cmbCameraDevices.Location = new System.Drawing.Point(230, 64);
            this.cmbCameraDevices.Name = "cmbCameraDevices";
            this.cmbCameraDevices.Size = new System.Drawing.Size(153, 24);
            this.cmbCameraDevices.TabIndex = 1;
            this.cmbCameraDevices.SelectedIndexChanged += new System.EventHandler(this.cmbCameraDevices_SelectedIndexChanged_1);
            // 
            // cmdCameraResolutions
            // 
            this.cmdCameraResolutions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.cmdCameraResolutions.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdCameraResolutions.FormattingEnabled = true;
            this.cmdCameraResolutions.Location = new System.Drawing.Point(14, 64);
            this.cmdCameraResolutions.Name = "cmdCameraResolutions";
            this.cmdCameraResolutions.Size = new System.Drawing.Size(153, 24);
            this.cmdCameraResolutions.TabIndex = 0;
            this.cmdCameraResolutions.SelectedIndexChanged += new System.EventHandler(this.cmdCameraResolutions_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 482);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            
            // 
            // CameraControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "CameraControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(804, 594);
            this.VisibleChanged += new System.EventHandler(this.CameraControl_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resolutionsLabel;
        private System.Windows.Forms.ComboBox cmbCameraDevices;
        private System.Windows.Forms.ComboBox cmdCameraResolutions;
        private System.Windows.Forms.Label cameraDevicesLabel;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
