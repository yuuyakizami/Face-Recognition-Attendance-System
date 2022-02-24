using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;


namespace Facial_Recognition_Attendance_System
{
    public partial class UserSpace : Form
    {
        #region Variables
        //Access Propery + Property Class + Name + Value
        private Capture videoCapture = null; // Camera

        private Image<Bgr, byte> currentFrame = null;
        Mat frame = new Mat();
        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");


        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();

        EigenFaceRecognizer recognizer;
        List<string> PersonsNames = new List<string>();

        #endregion
        public UserSpace()
        {
            InitializeComponent();
        }

        public void UserSpace_Load(object sender, EventArgs e)
        {
            videoCapture = new Capture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();

        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            // Step 1 Video Capture/Render
            videoCapture.Retrieve(frame, 300);
            currentFrame = frame.ToImage<Bgr, byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);

            // Render the video capture into the Picture box picCapture
            picCapture.Image = currentFrame.Bitmap;

            // Step 2 Face Detection //

            // Convert from bgr to Gray Image
            /*
             * The class Mat represents an n-dimensional dense numerical single-channel or multi-channel array. It can be used to store real or complex-valued vectors and matrices, grayscale or color images, voxel volumes, vector fields, point clouds, tensors, histograms (though, very high-dimensional histograms may be better stored in a SparseMat ). 
             */
            Mat grayImage = new Mat();
            /* 
             * CvInvoke library
             * - a library to invoke Open Cv functions
             * 
             * CvtColor method 
             * - Converts input image from one color space to another 
             * 
             */
            CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);

            // Enhance the image to get better result
            /* 
            * Equalize Hist method 
            * - The algorithm normalizes brightness and increase contrast of the image
            */
            CvInvoke.EqualizeHist(grayImage, grayImage);
            /*
             * Rectangle struct
             * - Stores a set of four integers that represent the location
             */

            Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
            if (faces.Length > 0)
            {

                foreach (var face in faces)
                {
                    // Draw square around each frame
                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                    // Step 3 Add Person
                    // Assign the face to the picture Box face picDetected

                    Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                    resultImage.ROI = face;
                    picDetected.SizeMode = PictureBoxSizeMode.StretchImage;
                    picDetected.Image = resultImage.Bitmap;


                }
            }
        }
        //Step 4: train Images .. we will use the saved images from the previous example 


        private void picCapture_Click(object sender, EventArgs e)
        {

        }

        private void btnDetectFaces_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                picDetected.Image = My_Image.ToBitmap();
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {

        }
    }
}