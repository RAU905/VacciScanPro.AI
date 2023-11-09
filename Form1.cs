using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace webcam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;


        void StartCamera()
        {
            try
            {

                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                videoCapture.NewFrame += new NewFrameEventHandler(Camera_On);
                videoCapture.Start();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            Pic1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                videoCapture.Stop();

            }
            catch
            {
                return;
            }

            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            Pic2.Image = Pic1.Image;
            string fileName = @"C:\Users\DELL\Desktop\Images\" + tbFileName.Text + ".jpg";
                var bitmap = new Bitmap(Pic2.Width,Pic2.Height);
            Pic2.DrawToBitmap(bitmap, Pic2.ClientRectangle);
            System.Drawing.Imaging.ImageFormat imageFormat = null;
            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            bitmap.Save(fileName, imageFormat);

        }

        
    }
}
