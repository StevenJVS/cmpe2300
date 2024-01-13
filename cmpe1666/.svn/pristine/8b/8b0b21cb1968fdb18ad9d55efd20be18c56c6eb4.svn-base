//***********************************************************************************
//Program: Pic Bender
//Description: Adjusts properties of image
//Date: 03/01/23
//Author: Steven Santiago
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace Lab2
{
    public partial class Form1 : Form
    {
        Bitmap original;//original image
        Bitmap filtered;//altered image
        int track;//track bar value

        Random random;//random number generator

        public Form1()
        {
            InitializeComponent();
            UI_mid.Text = UI_trackbar.Value.ToString();
        }
        //********************************************************************************************
        //Method: UI_loadpicture_btn_Click
        //Purpose: Open dialog for user to select image
        //Parameters: 
        //Returns: 
        //*********************************************************************************************
        private void UI_loadpicture_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (UI_openFileDialog1.ShowDialog() == DialogResult.OK)//if user slected an image
            {
                //set image box to image user selected
                UI_picturebox.Image = Image.FromFile(UI_openFileDialog1.FileName);
                original = new Bitmap(UI_picturebox.Image);//create bitmap for selected image
                UI_apply_btn.Enabled = true;
            }
        }
        //********************************************************************************************
        //Method: UI_apply_btn_Click
        //Purpose: Apply filter
        //Returns:
        //*********************************************************************************************
        private void UI_apply_btn_Click(object sender, EventArgs e)
        {
            UI_progressbar.Value = 0;
            filtered = new Bitmap(original);//create bitmap for altered image
            track = UI_trackbar.Value;//store track bar value
            UI_progressbar.Maximum = filtered.Width * filtered.Height;//set max value of progress bar


            //if wanted filter has been selected
            if (UI_contrast_rbtn.Checked)
            {
                contrast(filtered, track);
                UI_picturebox.Image = filtered;
            }
            else if (UI_tint_rbtn.Checked)
            {
                tint(filtered, track);
                UI_picturebox.Image = filtered;
            }
            else if (UI_BW_rbtn.Checked)
            {
                BW(filtered, track);
                UI_picturebox.Image = filtered;
            }
            else if (UI_noise_rbtn.Checked)
            {
                noise(filtered, track);
                UI_picturebox.Image = filtered;
            }
        }
        //********************************************************************************************
        //Method: BW
        //Purpose: Apply Black & White filter
        //Parameters: Bitmap filtered, int track
        //Returns: 
        //*********************************************************************************************
        private void BW(Bitmap filtered, int track)
        {

            double intensity = track / 100.0;//intensity percentage of track value

            if (UI_picturebox.Image != null)
            {
                //go through the image dimensions
                for (int x = 0; x < filtered.Width; x++)
                {


                    for (int y = 0; y < filtered.Height; y++)
                    {


                        Color pixel = filtered.GetPixel(x, y);//get color for selected pixel
                        int avg = (pixel.R + pixel.G + pixel.B) / 3;

                        //set new grey color
                        int r = (int)(pixel.R + ((avg - pixel.R) * intensity));
                        int g = (int)(pixel.G + ((avg - pixel.G) * intensity));
                        int b = (int)(pixel.B + ((avg - pixel.B) * intensity));

                        //apply filter
                        filtered.SetPixel(x, y, Color.FromArgb(r,g,b));
                        UI_progressbar.PerformStep();//increment progress bar
                    }
                }

            }
        }
        //********************************************************************************************
        //Method: BW
        //Purpose: Apply Black & White filter
        //Parameters: Bitmap filtered, int track
        //Returns: 
        //*********************************************************************************************
        private void contrast(Bitmap filtered, int track)
        {
            if (UI_picturebox.Image != null)
            {
                //go through image dimensions
                for (int x = 0; x < filtered.Width; x++)
                {

                    for (int y = 0; y < filtered.Height; y++)
                    {

                        Color originalColor = filtered.GetPixel(x, y);//get color for selected pixel

                        //adjust rgb compnent of color
                        int red = newpixel(originalColor.R, track);
                        int green = newpixel(originalColor.G, track);
                        int blue = newpixel(originalColor.B, track);

                        //set new color
                        //ensures rgb doesnt go over max value
                        int adjustedRed = (int)Math.Min(Math.Max(red, 0), 255);
                        int adjustedGreen = (int)Math.Min(Math.Max(green, 0), 255);
                        int adjustedBlue = (int)Math.Min(Math.Max(blue, 0), 255);

                        //store new color
                        Color adjustedColor = Color.FromArgb(adjustedRed, adjustedGreen, adjustedBlue);
                        filtered.SetPixel(x, y, adjustedColor);//apply adjusted color
                        UI_progressbar.PerformStep();//increment progress bar
                    }
                }
            }
        }
        //********************************************************************************************
        //Method: newpixel
        //Purpose: adjust contrast of specified color
        //Parameters: int pixel, intensity
        //Returns: num value
        //*********************************************************************************************
        private int newpixel(int pixel, double intensity)
        {
            //return original pixel 
            if (intensity == 50)
            {
                return pixel;
            }
            if (pixel > 128)
            {
                //return increased pixel
                pixel += (int)(intensity /5);
/*                pixel += (int)(intensity/5);*/
                return pixel;

            }
            if (pixel < 128)
            {
                //return decreased pixel
                pixel -= (int)(intensity /5);
/*                pixel = (int)((pixel - (pixel * (intensity * 0.2)))+255);*/
                return pixel;
            }           
            else
            {
                //return original pixel if error occurs
                return pixel;
            }

        }
        //********************************************************************************************
        //Method: tint
        //Purpose: Apply tint
        //Parameters: Bitmap filtered, int track
        //Returns: 
        //*********************************************************************************************
        private void tint(Bitmap filtered, int track)
        {
            double intensity = track;//track value
            //variables for green and red adjustments
            int adjustedGreen;
            int adjustedRed;

            if (UI_picturebox.Image != null)
            {
                //go through image dimensions
                for (int x = 0; x < filtered.Width; x++)
                {

                    for (int y = 0; y < filtered.Height; y++)
                    {

                        Color originalColor = filtered.GetPixel(x, y);//got color pixel

                        //store values for red and green properties
                        adjustedGreen = originalColor.G;
                        adjustedRed = originalColor.R;

                        //if red is favored
                        if (intensity > 50)
                        {
                            adjustedRed = (int)(originalColor.R + (50 - intensity));
                            //ensures rgb doesnt go over max value
                            adjustedRed = Math.Max(0, Math.Min(255, adjustedRed));

                        }
                        //if green is favored
                        if (intensity < 50)
                        {
                            adjustedGreen = (int)(originalColor.G + (intensity - 50));
                            //ensures rgb doesnt go over max value
                            adjustedGreen = Math.Max(0, Math.Min(255, adjustedGreen));
                        }
                        //store color adjustment
                        Color adjustedColor = Color.FromArgb(adjustedRed, adjustedGreen, originalColor.B);
                        filtered.SetPixel(x, y, adjustedColor);//apply colors
                        UI_progressbar.PerformStep();//increment progress bar
                    }
                }
            }
        }
        //********************************************************************************************
        //Method: noise
        //Purpose: Apply noise
        //Parameters: Bitmap filtered, int track
        //Returns: 
        //*********************************************************************************************
        private void noise(Bitmap filtered, int track)
        {
            random = new Random();//new random number generator

            //go through dimensions of image
            for (int x = 0; x < filtered.Width; x++)
            {

                for (int y = 0; y < filtered.Height; y++)
                {

                    //get pixel color
                    Color pixel = filtered.GetPixel(x, y);

                    //adjust noise
                    int r = pixel.R + (random.Next(-255,255) % ((track + 1) *2)) - track;
                    int g = pixel.G + (random.Next(-255, 255) % ((track + 1) * 2)) - track;
                    int b = pixel.B + (random.Next(-255,255) % ((track + 1) *2)) - track;

                    //ensures rgb doesnt go over max value
                    r = Math.Max(0, Math.Min(255, r));
                    g = Math.Max(0, Math.Min(255, g));
                    b = Math.Max(0, Math.Min(255, b));

                    Color newPixel = Color.FromArgb(pixel.A, r, g, b);//store color
                    filtered.SetPixel(x, y, newPixel);//apply filter
                    UI_progressbar.PerformStep();//increment progress bar
                }
            }
        }
        //********************************************************************************************
        //Method: UI_Radio_Click
        //Purpose: Change labels
        //Parameters: Bitmap filtered, int track
        //Returns: 
        //*********************************************************************************************
        private void UI_Radio_Click(object sender, EventArgs e)
        {
            //if tint radio button is checked
            if(UI_tint_rbtn.Checked)
            {
                //change label to colors
                UI_min.Text = "Red";
                UI_max.Text = "Green";
                //change middle label to include color
                if (UI_trackbar.Value > 50)
                {
                    UI_mid.Text = $"To green: " + UI_trackbar.Value.ToString();
                }
                if (UI_trackbar.Value < 50)
                {
                    UI_mid.Text = $"To red: " + UI_trackbar.Value.ToString();
                }
            }
            else
            //return to default if s different radio button is selected
            {
                UI_mid.Text = UI_trackbar.Value.ToString();
                UI_min.Text = "Less";
                UI_max.Text = "More";
            }

        }
        //********************************************************************************************
        //Method: UI_trackbar_Scroll
        //Purpose: Update label of scroll bar
        //Parameters:
        //Returns: 
        //*********************************************************************************************
        private void UI_trackbar_Scroll(object sender, EventArgs e)
        {
            //if tint radio button is checked
            if (UI_tint_rbtn.Checked)
            {
                //change label to colors
                UI_min.Text = "Red";
                UI_max.Text = "Green";
                //change middle label to include color
                if (UI_trackbar.Value > 50)
                {
                    //formula to change the value of trackbar to wanted value
                    UI_mid.Text = $"To green: " + (UI_trackbar.Value - 50).ToString();
                }
                if (UI_trackbar.Value < 50)
                {
                    //formula to change the value of trackbar to wanted value
                    UI_mid.Text = $"To red: " + ((UI_trackbar.Value* - 1) + 50).ToString();
                }
                //return to default if s different radio button is selected
            }
            else
                UI_mid.Text = UI_trackbar.Value.ToString();
        }
    }
}
