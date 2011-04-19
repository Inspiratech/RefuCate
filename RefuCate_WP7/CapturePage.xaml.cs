using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using Microsoft.Phone;
using System.IO;
using RefuCate_WPF.Classes;
using System.Windows.Controls.Primitives;

namespace RefuCate_WP7
{

    public partial class CapturePage : PhoneApplicationPage
    {
        //Object used for databinding
        Person person;
        CameraCaptureTask ctask;
        WriteableBitmap CapturedImage;
        public CapturePage()
        {
            InitializeComponent();
            //Actually get databinding set up
            person = new Person();
            (App.Current.RootVisual as PhoneApplicationFrame).DataContext = person;
            ctask = new CameraCaptureTask();
            ctask.Completed += new EventHandler<PhotoResult>(ctask_Completed);

        }

        void btnDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submitting to cloud!");//TODO confirmation box
        }

        void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clearing form..."); //TODO confirmation box

            person.clear();
            DateTime now = DateTime.Now;
            DOB.Value = now;

            picEyes.SelectedIndex = 0;
            picHair.SelectedIndex = 0;
            picSkin.SelectedIndex = 0;

            txtDefiningCharacteristics.Text = "";
            txtHeight.Text = "";
            txtSeeking.Text = "";
            txtKin.Text = "";

            imgPicture.Source = null;
            
 
        }

        private void picClick(object sender, RoutedEventArgs e)
        {
            ctask.Show();
        }


        void btnCamera_Click(object sender, EventArgs e)
        {
            //textStatus.Text = "";
            //Show the camera.
            ctask.Show(); //Warning: Multiple taps break it!
            //IF: can't test this on emulator, needs to be done on device

            //Set progress bar to visible to show time between user snapshot and decoding
            //of image into a writeable bitmap object.
            //progressBar1.Visibility = Visibility.Visible;
        }

        void ctask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK && e.ChosenPhoto != null)
            {
                //Take JPEG stream and decode into a WriteableBitmap object
                CapturedImage = PictureDecoder.DecodeJpeg(e.ChosenPhoto);
                ImageBrush brush = new ImageBrush();
                brush.ImageSource = CapturedImage;
                //Collapse visibility on the progress bar once writeable bitmap is visible.
                //progressBar1.Visibility = Visibility.Collapsed;
                btn_Pic.Background = brush;
            }
            else
            {
                //textStatus.Text = "You decided not to take a picture.";
            }

            imgPicture.Source = CapturedImage;

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            //loading logic here

        }

        private void DOB_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {

        }
    }
}
