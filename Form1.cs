using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Facial_Recognition_Attendance_System
{

    public partial class Form1 : Form
    {
        #region Variables
        private Capture videoCapture = null;
        private Image<Bgr, byte> currentFrame = null;
        Mat frame = new Mat();
        public FileDialog music = null;

        private bool facesDetectionEnabled = false;
        private CascadeClassifier facesCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        List<Image<Gray, byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
        bool EnableSaveImage = false;



        #endregion
        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            videoCapture = new Capture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            // Step 1: Video Capture
            videoCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);

            // Step 2: Face Detection
            if (facesDetectionEnabled)
            {
                //Convert from Bgr to Gray Image
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                // Enhance the image to get better result
                CvInvoke.EqualizeHist(grayImage, grayImage);

                Rectangle[] faces = facesCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                // if faces detected 

                if (faces.Length > 0)
                {
                    int faceId = 0;
                    foreach (var face in faces)
                    {
                        //Draw square around each face
                        CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                        //Step 3 Add Persons
                        // Assign the face to the picture Box face picDetected
                        Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, byte>();
                        resultImage.ROI = face;
                        picDetected.SizeMode = PictureBoxSizeMode.StretchImage;
                        picDetected.Image = resultImage.Bitmap;

                        if (EnableSaveImage)
                        {
                            // We will create a directory if does not exist
                            string path = @"D:\Thesis 3";
                           
                            
                        }
                    }
                }
            }
            // Render the video capture into the Picture Box picCapture 
            picCapture.Image = currentFrame.Bitmap;

        }

        private void btnDetectFaces_Click(object sender, EventArgs e)
        {
            facesDetectionEnabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnAddPerson.Enabled = false;
            EnableSaveImage = false;
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnAddPerson.Enabled = false;
            EnableSaveImage = true;
        }


        /*System.Media.SoundPlayer player = new System.Media.SoundPlayer();
          player.SoundLocation = @"D:\Audio\Backing Tracks\God Knows Aya Hirano.wav";
          player.Load();
          player.Play();*/

        public void Play()
        {

        }

        private void btnTrain_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
