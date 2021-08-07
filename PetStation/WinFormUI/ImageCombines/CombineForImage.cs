using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.ImagesResize;

namespace WinFormUI.ImageCombines
{
    public static class CombineForImage
    {
        public static bool combineFor2Images(string fileRoad, string fileRoad2)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoad);
            Image image2 = Image.FromFile(fileRoad2);

            var resizeImage1 = ImageResize.ResizeImage(image, 600, 850);
            var resizeImage2 = ImageResize.ResizeImage(image2, 600, 850);

            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();

            int width = 1200;
            int height = Math.Max(400, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(270, 0));
            graphics.DrawImage(resizeImage2, new Point(270, 900));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();

            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }

        public static bool combineFor3Images(string fileRoad, string fileRoad2, string fileRoad3)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoad);
            Image image2 = Image.FromFile(fileRoad2);
            Image image3 = Image.FromFile(fileRoad3);

            var resizeImage1 = ImageResize.ResizeImage(image, 600, 850);
            var resizeImage2 = ImageResize.ResizeImage(image2, 600, 850);
            var resizeImage3 = ImageResize.ResizeImage(image3, 600, 850);

            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();

            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(270, 900));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();

            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }

        public static bool combineFor4Images(string fileRoad, string fileRoad2, string fileRoad3, string fileRoad4)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoad);
            Image image2 = Image.FromFile(fileRoad2);
            Image image3 = Image.FromFile(fileRoad3);
            Image image4 = Image.FromFile(fileRoad4);

            var resizeImage1 = ImageResize.ResizeImage(image, 600, 850);
            var resizeImage2 = ImageResize.ResizeImage(image2, 600, 850);
            var resizeImage3 = ImageResize.ResizeImage(image3, 600, 850);
            var resizeImage4 = ImageResize.ResizeImage(image4, 600, 850);

            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();

            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(0, 900));
            graphics.DrawImage(resizeImage4, new Point(resizeImage3.Width, 900));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }
        public static bool combineFor5Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());

            var resizeImage1 = ImageResize.ResizeImage(image, 550, 550);
            var resizeImage2 = ImageResize.ResizeImage(image2, 550, 550);
            var resizeImage3 = ImageResize.ResizeImage(image3, 550, 550);
            var resizeImage4 = ImageResize.ResizeImage(image4, 550, 550);
            var resizeImage5 = ImageResize.ResizeImage(image5, 550, 550);

            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();

            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(280, 600));
            graphics.DrawImage(resizeImage4, new Point(0, 1200));
            graphics.DrawImage(resizeImage5, new Point(resizeImage4.Width, 1200));




            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }

        public static bool combineFor6Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());
            Image image6 = Image.FromFile(fileRoads[5].ToString());


            var resizeImage1 = ImageResize.ResizeImage(image, 500, 500);
            var resizeImage2 = ImageResize.ResizeImage(image2, 500, 500);
            var resizeImage3 = ImageResize.ResizeImage(image3, 500, 500);
            var resizeImage4 = ImageResize.ResizeImage(image4, 500, 500);
            var resizeImage5 = ImageResize.ResizeImage(image5, 500, 500);
            var resizeImage6 = ImageResize.ResizeImage(image6, 500, 500);


            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();
            resizeImage6.MakeTransparent();



            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(110, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(110, 560));
            graphics.DrawImage(resizeImage4, new Point(resizeImage3.Width, 560));
            graphics.DrawImage(resizeImage5, new Point(110, 1120));
            graphics.DrawImage(resizeImage6, new Point(resizeImage5.Width, 1120));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();
            image6.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }
        public static bool combineFor7Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());
            Image image6 = Image.FromFile(fileRoads[5].ToString());
            Image image7 = Image.FromFile(fileRoads[6].ToString());


            var resizeImage1 = ImageResize.ResizeImage(image, 400, 550);
            var resizeImage2 = ImageResize.ResizeImage(image2, 400, 550);
            var resizeImage3 = ImageResize.ResizeImage(image3, 400, 550);
            var resizeImage4 = ImageResize.ResizeImage(image4, 400, 550);
            var resizeImage5 = ImageResize.ResizeImage(image5, 400, 550);
            var resizeImage6 = ImageResize.ResizeImage(image6, 400, 550);
            var resizeImage7 = ImageResize.ResizeImage(image7, 400, 550);


            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();
            resizeImage6.MakeTransparent();
            resizeImage7.MakeTransparent();


            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(10, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(resizeImage1.Width + resizeImage2.Width, 0));
            graphics.DrawImage(resizeImage4, new Point(400, 600));
            graphics.DrawImage(resizeImage5, new Point(10, 1200));
            graphics.DrawImage(resizeImage6, new Point(resizeImage4.Width, 1200));
            graphics.DrawImage(resizeImage7, new Point(resizeImage4.Width + resizeImage4.Width, 1200));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();
            image6.Dispose();
            image7.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }

        public static bool combineFor8Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());
            Image image6 = Image.FromFile(fileRoads[5].ToString());
            Image image7 = Image.FromFile(fileRoads[6].ToString());
            Image image8 = Image.FromFile(fileRoads[7].ToString());


            var resizeImage1 = ImageResize.ResizeImage(image, 600, 450);
            var resizeImage2 = ImageResize.ResizeImage(image2, 600, 450);
            var resizeImage3 = ImageResize.ResizeImage(image3, 600, 450);
            var resizeImage4 = ImageResize.ResizeImage(image4, 600, 450);
            var resizeImage5 = ImageResize.ResizeImage(image5, 600, 450);
            var resizeImage6 = ImageResize.ResizeImage(image6, 600, 450);
            var resizeImage7 = ImageResize.ResizeImage(image7, 600, 450);
            var resizeImage8 = ImageResize.ResizeImage(image8, 600, 450);


            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();
            resizeImage6.MakeTransparent();
            resizeImage7.MakeTransparent();
            resizeImage8.MakeTransparent();

            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(0, 450));
            graphics.DrawImage(resizeImage4, new Point(resizeImage3.Width, 450));
            graphics.DrawImage(resizeImage5, new Point(0, 900));
            graphics.DrawImage(resizeImage6, new Point(resizeImage5.Width, 900));
            graphics.DrawImage(resizeImage7, new Point(0, 1350));
            graphics.DrawImage(resizeImage8, new Point(resizeImage7.Width, 1350));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();
            image6.Dispose();
            image7.Dispose();
            image8.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }

        public static bool combineFor9Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());
            Image image6 = Image.FromFile(fileRoads[5].ToString());
            Image image7 = Image.FromFile(fileRoads[6].ToString());
            Image image8 = Image.FromFile(fileRoads[7].ToString());
            Image image9 = Image.FromFile(fileRoads[8].ToString());


            var resizeImage1 = ImageResize.ResizeImage(image, 400, 600);
            var resizeImage2 = ImageResize.ResizeImage(image2, 400, 600);
            var resizeImage3 = ImageResize.ResizeImage(image3, 400, 600);
            var resizeImage4 = ImageResize.ResizeImage(image4, 400, 600);
            var resizeImage5 = ImageResize.ResizeImage(image5, 400, 600);
            var resizeImage6 = ImageResize.ResizeImage(image6, 400, 600);
            var resizeImage7 = ImageResize.ResizeImage(image7, 400, 600);
            var resizeImage8 = ImageResize.ResizeImage(image8, 400, 600);
            var resizeImage9 = ImageResize.ResizeImage(image9, 400, 600);

            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();
            resizeImage6.MakeTransparent();
            resizeImage7.MakeTransparent();
            resizeImage8.MakeTransparent();
            resizeImage9.MakeTransparent();

            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(resizeImage1.Width + resizeImage2.Width, 0));
            graphics.DrawImage(resizeImage4, new Point(0, 600));
            graphics.DrawImage(resizeImage5, new Point(resizeImage4.Width, 600));
            graphics.DrawImage(resizeImage6, new Point(resizeImage4.Width + resizeImage5.Width, 600));
            graphics.DrawImage(resizeImage7, new Point(0, 1200));
            graphics.DrawImage(resizeImage8, new Point(resizeImage7.Width, 1200));
            graphics.DrawImage(resizeImage9, new Point(resizeImage7.Width + resizeImage8.Width, 1200));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();
            image6.Dispose();
            image7.Dispose();
            image8.Dispose();
            image9.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }
        public static bool combineFor10Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());
            Image image6 = Image.FromFile(fileRoads[5].ToString());
            Image image7 = Image.FromFile(fileRoads[6].ToString());
            Image image8 = Image.FromFile(fileRoads[7].ToString());
            Image image9 = Image.FromFile(fileRoads[8].ToString());
            Image image10 = Image.FromFile(fileRoads[9].ToString());


            var resizeImage1 = ImageResize.ResizeImage(image, 300, 550);
            var resizeImage2 = ImageResize.ResizeImage(image2, 300, 550);
            var resizeImage3 = ImageResize.ResizeImage(image3, 300, 550);
            var resizeImage4 = ImageResize.ResizeImage(image4, 300, 550);
            var resizeImage5 = ImageResize.ResizeImage(image5, 300, 550);
            var resizeImage6 = ImageResize.ResizeImage(image6, 300, 550);
            var resizeImage7 = ImageResize.ResizeImage(image7, 300, 550);
            var resizeImage8 = ImageResize.ResizeImage(image8, 300, 550);
            var resizeImage9 = ImageResize.ResizeImage(image9, 600, 600);
            var resizeImage10 = ImageResize.ResizeImage(image10, 600, 600);


            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();
            resizeImage6.MakeTransparent();
            resizeImage7.MakeTransparent();
            resizeImage8.MakeTransparent();
            resizeImage9.MakeTransparent();
            resizeImage10.MakeTransparent();

            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(resizeImage1.Width + resizeImage2.Width, 0));
            graphics.DrawImage(resizeImage4, new Point(resizeImage1.Width + resizeImage2.Width + resizeImage3.Width, 0));
            graphics.DrawImage(resizeImage5, new Point(0, 550));
            graphics.DrawImage(resizeImage6, new Point(resizeImage5.Width, 550));
            graphics.DrawImage(resizeImage7, new Point(resizeImage5.Width + resizeImage6.Width, 550));
            graphics.DrawImage(resizeImage8, new Point(resizeImage5.Width + resizeImage6.Width + resizeImage7.Width, 550));
            graphics.DrawImage(resizeImage9, new Point(0, 1100));
            graphics.DrawImage(resizeImage10, new Point(resizeImage9.Width, 1100));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();
            image6.Dispose();
            image7.Dispose();
            image8.Dispose();
            image9.Dispose();
            image10.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }

        public static bool combineFor11Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());
            Image image6 = Image.FromFile(fileRoads[5].ToString());
            Image image7 = Image.FromFile(fileRoads[6].ToString());
            Image image8 = Image.FromFile(fileRoads[7].ToString());
            Image image9 = Image.FromFile(fileRoads[8].ToString());
            Image image10 = Image.FromFile(fileRoads[9].ToString());
            Image image11 = Image.FromFile(fileRoads[10].ToString());


            var resizeImage1 = ImageResize.ResizeImage(image, 300, 550);
            var resizeImage2 = ImageResize.ResizeImage(image2, 300, 550);
            var resizeImage3 = ImageResize.ResizeImage(image3, 300, 550);
            var resizeImage4 = ImageResize.ResizeImage(image4, 300, 550);
            var resizeImage5 = ImageResize.ResizeImage(image5, 300, 550);
            var resizeImage6 = ImageResize.ResizeImage(image6, 300, 550);
            var resizeImage7 = ImageResize.ResizeImage(image7, 300, 550);
            var resizeImage8 = ImageResize.ResizeImage(image8, 300, 550);
            var resizeImage9 = ImageResize.ResizeImage(image9, 400, 600);
            var resizeImage10 = ImageResize.ResizeImage(image10, 400, 600);
            var resizeImage11 = ImageResize.ResizeImage(image11, 400, 600);


            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();
            resizeImage6.MakeTransparent();
            resizeImage7.MakeTransparent();
            resizeImage8.MakeTransparent();
            resizeImage9.MakeTransparent();
            resizeImage10.MakeTransparent();
            resizeImage11.MakeTransparent();


            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(resizeImage1.Width + resizeImage2.Width, 0));
            graphics.DrawImage(resizeImage4, new Point(resizeImage1.Width + resizeImage2.Width + resizeImage3.Width, 0));
            graphics.DrawImage(resizeImage5, new Point(0, 550));
            graphics.DrawImage(resizeImage6, new Point(resizeImage5.Width, 550));
            graphics.DrawImage(resizeImage7, new Point(resizeImage5.Width + resizeImage6.Width, 550));
            graphics.DrawImage(resizeImage8, new Point(resizeImage5.Width + resizeImage6.Width + resizeImage7.Width, 550));
            graphics.DrawImage(resizeImage9, new Point(0, 1100));
            graphics.DrawImage(resizeImage10, new Point(resizeImage9.Width, 1100));
            graphics.DrawImage(resizeImage11, new Point(resizeImage9.Width + resizeImage10.Width, 1100));


            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();
            image6.Dispose();
            image7.Dispose();
            image8.Dispose();
            image9.Dispose();
            image10.Dispose();
            image11.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }
        public static bool combineFor12Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());
            Image image6 = Image.FromFile(fileRoads[5].ToString());
            Image image7 = Image.FromFile(fileRoads[6].ToString());
            Image image8 = Image.FromFile(fileRoads[7].ToString());
            Image image9 = Image.FromFile(fileRoads[8].ToString());
            Image image10 = Image.FromFile(fileRoads[9].ToString());
            Image image11 = Image.FromFile(fileRoads[10].ToString());
            Image image12 = Image.FromFile(fileRoads[11].ToString());


            var resizeImage1 = ImageResize.ResizeImage(image, 300, 550);
            var resizeImage2 = ImageResize.ResizeImage(image2, 300, 550);
            var resizeImage3 = ImageResize.ResizeImage(image3, 300, 550);
            var resizeImage4 = ImageResize.ResizeImage(image4, 300, 550);
            var resizeImage5 = ImageResize.ResizeImage(image5, 300, 550);
            var resizeImage6 = ImageResize.ResizeImage(image6, 300, 550);
            var resizeImage7 = ImageResize.ResizeImage(image7, 300, 550);
            var resizeImage8 = ImageResize.ResizeImage(image8, 300, 550);
            var resizeImage9 = ImageResize.ResizeImage(image9, 300, 550);
            var resizeImage10 = ImageResize.ResizeImage(image10, 300, 550);
            var resizeImage11 = ImageResize.ResizeImage(image11, 300, 550);
            var resizeImage12 = ImageResize.ResizeImage(image12, 300, 550);

            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();
            resizeImage6.MakeTransparent();
            resizeImage7.MakeTransparent();
            resizeImage8.MakeTransparent();
            resizeImage9.MakeTransparent();
            resizeImage10.MakeTransparent();
            resizeImage11.MakeTransparent();
            resizeImage12.MakeTransparent();



            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(resizeImage1.Width + resizeImage2.Width, 0));
            graphics.DrawImage(resizeImage4, new Point(resizeImage1.Width + resizeImage2.Width + resizeImage3.Width, 0));
            graphics.DrawImage(resizeImage5, new Point(0, 550));
            graphics.DrawImage(resizeImage6, new Point(resizeImage5.Width, 550));
            graphics.DrawImage(resizeImage7, new Point(resizeImage5.Width + resizeImage6.Width, 550));
            graphics.DrawImage(resizeImage8, new Point(resizeImage5.Width + resizeImage6.Width + resizeImage7.Width, 550));
            graphics.DrawImage(resizeImage9, new Point(0, 1100));
            graphics.DrawImage(resizeImage10, new Point(resizeImage9.Width, 1100));
            graphics.DrawImage(resizeImage11, new Point(resizeImage9.Width + resizeImage10.Width, 1100));
            graphics.DrawImage(resizeImage12, new Point(resizeImage9.Width + resizeImage10.Width + resizeImage11.Width, 1100));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();
            image6.Dispose();
            image7.Dispose();
            image8.Dispose();
            image9.Dispose();
            image10.Dispose();
            image11.Dispose();
            image12.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }
        public static bool combineFor13Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());
            Image image6 = Image.FromFile(fileRoads[5].ToString());
            Image image7 = Image.FromFile(fileRoads[6].ToString());
            Image image8 = Image.FromFile(fileRoads[7].ToString());
            Image image9 = Image.FromFile(fileRoads[8].ToString());
            Image image10 = Image.FromFile(fileRoads[9].ToString());
            Image image11 = Image.FromFile(fileRoads[10].ToString());
            Image image12 = Image.FromFile(fileRoads[11].ToString());
            Image image13 = Image.FromFile(fileRoads[12].ToString());


            var resizeImage1 = ImageResize.ResizeImage(image, 400, 360);
            var resizeImage2 = ImageResize.ResizeImage(image2, 400, 360);
            var resizeImage3 = ImageResize.ResizeImage(image3, 400, 360);
            var resizeImage4 = ImageResize.ResizeImage(image4, 400, 360);
            var resizeImage5 = ImageResize.ResizeImage(image5, 400, 360);
            var resizeImage6 = ImageResize.ResizeImage(image6, 400, 360);
            var resizeImage7 = ImageResize.ResizeImage(image7, 400, 360);
            var resizeImage8 = ImageResize.ResizeImage(image8, 400, 360);
            var resizeImage9 = ImageResize.ResizeImage(image9, 400, 360);
            var resizeImage10 = ImageResize.ResizeImage(image10, 400, 360);
            var resizeImage11 = ImageResize.ResizeImage(image11, 400, 360);
            var resizeImage12 = ImageResize.ResizeImage(image12, 400, 360);
            var resizeImage13 = ImageResize.ResizeImage(image13, 400, 360);


            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();
            resizeImage6.MakeTransparent();
            resizeImage7.MakeTransparent();
            resizeImage8.MakeTransparent();
            resizeImage9.MakeTransparent();
            resizeImage10.MakeTransparent();
            resizeImage11.MakeTransparent();
            resizeImage12.MakeTransparent();
            resizeImage13.MakeTransparent();


            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(resizeImage1.Width + resizeImage2.Width, 0));
            graphics.DrawImage(resizeImage4, new Point(0, 360));
            graphics.DrawImage(resizeImage5, new Point(resizeImage4.Width, 360));
            graphics.DrawImage(resizeImage6, new Point(resizeImage4.Width + resizeImage5.Width, 360));
            graphics.DrawImage(resizeImage7, new Point(410, 720));
            graphics.DrawImage(resizeImage8, new Point(0, 1080));
            graphics.DrawImage(resizeImage9, new Point(resizeImage8.Width, 1080));
            graphics.DrawImage(resizeImage10, new Point(resizeImage8.Width + resizeImage9.Width, 1080));
            graphics.DrawImage(resizeImage11, new Point(0, 1440));
            graphics.DrawImage(resizeImage12, new Point(resizeImage11.Width, 1440));
            graphics.DrawImage(resizeImage13, new Point(resizeImage11.Width + resizeImage12.Width, 1440));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();
            image6.Dispose();
            image7.Dispose();
            image8.Dispose();
            image9.Dispose();
            image10.Dispose();
            image11.Dispose();
            image12.Dispose();
            image13.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }
        public static bool combineFor14Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());
            Image image6 = Image.FromFile(fileRoads[5].ToString());
            Image image7 = Image.FromFile(fileRoads[6].ToString());
            Image image8 = Image.FromFile(fileRoads[7].ToString());
            Image image9 = Image.FromFile(fileRoads[8].ToString());
            Image image10 = Image.FromFile(fileRoads[9].ToString());
            Image image11 = Image.FromFile(fileRoads[10].ToString());
            Image image12 = Image.FromFile(fileRoads[11].ToString());
            Image image13 = Image.FromFile(fileRoads[12].ToString());
            Image image14 = Image.FromFile(fileRoads[13].ToString());


            var resizeImage1 = ImageResize.ResizeImage(image, 400, 360);
            var resizeImage2 = ImageResize.ResizeImage(image2, 400, 360);
            var resizeImage3 = ImageResize.ResizeImage(image3, 400, 360);
            var resizeImage4 = ImageResize.ResizeImage(image4, 400, 360);
            var resizeImage5 = ImageResize.ResizeImage(image5, 400, 360);
            var resizeImage6 = ImageResize.ResizeImage(image6, 400, 360);
            var resizeImage7 = ImageResize.ResizeImage(image7, 400, 360);
            var resizeImage8 = ImageResize.ResizeImage(image8, 400, 360);
            var resizeImage9 = ImageResize.ResizeImage(image9, 400, 360);
            var resizeImage10 = ImageResize.ResizeImage(image10, 400, 360);
            var resizeImage11 = ImageResize.ResizeImage(image11, 400, 360);
            var resizeImage12 = ImageResize.ResizeImage(image12, 400, 360);
            var resizeImage13 = ImageResize.ResizeImage(image13, 600, 360);
            var resizeImage14 = ImageResize.ResizeImage(image14, 600, 360);


            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();
            resizeImage6.MakeTransparent();
            resizeImage7.MakeTransparent();
            resizeImage8.MakeTransparent();
            resizeImage9.MakeTransparent();
            resizeImage10.MakeTransparent();
            resizeImage11.MakeTransparent();
            resizeImage12.MakeTransparent();
            resizeImage13.MakeTransparent();
            resizeImage14.MakeTransparent();


            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(resizeImage1.Width + resizeImage2.Width, 0));
            graphics.DrawImage(resizeImage4, new Point(0, 360));
            graphics.DrawImage(resizeImage5, new Point(resizeImage4.Width, 360));
            graphics.DrawImage(resizeImage6, new Point(resizeImage4.Width + resizeImage5.Width, 360));
            graphics.DrawImage(resizeImage7, new Point(0, 720));
            graphics.DrawImage(resizeImage8, new Point(resizeImage7.Width, 720));
            graphics.DrawImage(resizeImage9, new Point(resizeImage7.Width + resizeImage8.Width, 720));
            graphics.DrawImage(resizeImage10, new Point(0, 1080));
            graphics.DrawImage(resizeImage11, new Point(resizeImage10.Width, 1080));
            graphics.DrawImage(resizeImage12, new Point(resizeImage10.Width + resizeImage11.Width, 1080));
            graphics.DrawImage(resizeImage13, new Point(0, 1440));
            graphics.DrawImage(resizeImage14, new Point(resizeImage13.Width, 1440));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();
            image6.Dispose();
            image7.Dispose();
            image8.Dispose();
            image9.Dispose();
            image10.Dispose();
            image11.Dispose();
            image12.Dispose();
            image13.Dispose();
            image14.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }
        public static bool combineFor15Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());
            Image image6 = Image.FromFile(fileRoads[5].ToString());
            Image image7 = Image.FromFile(fileRoads[6].ToString());
            Image image8 = Image.FromFile(fileRoads[7].ToString());
            Image image9 = Image.FromFile(fileRoads[8].ToString());
            Image image10 = Image.FromFile(fileRoads[9].ToString());
            Image image11 = Image.FromFile(fileRoads[10].ToString());
            Image image12 = Image.FromFile(fileRoads[11].ToString());
            Image image13 = Image.FromFile(fileRoads[12].ToString());
            Image image14 = Image.FromFile(fileRoads[13].ToString());
            Image image15 = Image.FromFile(fileRoads[14].ToString());


            var resizeImage1 = ImageResize.ResizeImage(image, 400, 360);
            var resizeImage2 = ImageResize.ResizeImage(image2, 400, 360);
            var resizeImage3 = ImageResize.ResizeImage(image3, 400, 360);
            var resizeImage4 = ImageResize.ResizeImage(image4, 400, 360);
            var resizeImage5 = ImageResize.ResizeImage(image5, 400, 360);
            var resizeImage6 = ImageResize.ResizeImage(image6, 400, 360);
            var resizeImage7 = ImageResize.ResizeImage(image7, 400, 360);
            var resizeImage8 = ImageResize.ResizeImage(image8, 400, 360);
            var resizeImage9 = ImageResize.ResizeImage(image9, 400, 360);
            var resizeImage10 = ImageResize.ResizeImage(image10, 400, 360);
            var resizeImage11 = ImageResize.ResizeImage(image11, 400, 360);
            var resizeImage12 = ImageResize.ResizeImage(image12, 400, 360);
            var resizeImage13 = ImageResize.ResizeImage(image13, 400, 360);
            var resizeImage14 = ImageResize.ResizeImage(image14, 400, 360);
            var resizeImage15 = ImageResize.ResizeImage(image15, 400, 360);

            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();
            resizeImage6.MakeTransparent();
            resizeImage7.MakeTransparent();
            resizeImage8.MakeTransparent();
            resizeImage9.MakeTransparent();
            resizeImage10.MakeTransparent();
            resizeImage11.MakeTransparent();
            resizeImage12.MakeTransparent();
            resizeImage13.MakeTransparent();
            resizeImage14.MakeTransparent();
            resizeImage15.MakeTransparent();


            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(resizeImage1.Width + resizeImage2.Width, 0));
            graphics.DrawImage(resizeImage4, new Point(0, 360));
            graphics.DrawImage(resizeImage5, new Point(resizeImage4.Width, 360));
            graphics.DrawImage(resizeImage6, new Point(resizeImage4.Width + resizeImage5.Width, 360));
            graphics.DrawImage(resizeImage7, new Point(0, 720));
            graphics.DrawImage(resizeImage8, new Point(resizeImage7.Width, 720));
            graphics.DrawImage(resizeImage9, new Point(resizeImage7.Width + resizeImage8.Width, 720));
            graphics.DrawImage(resizeImage10, new Point(0, 1080));
            graphics.DrawImage(resizeImage11, new Point(resizeImage10.Width, 1080));
            graphics.DrawImage(resizeImage12, new Point(resizeImage10.Width + resizeImage11.Width, 1080));
            graphics.DrawImage(resizeImage13, new Point(0, 1440));
            graphics.DrawImage(resizeImage14, new Point(resizeImage13.Width, 1440));
            graphics.DrawImage(resizeImage15, new Point(resizeImage13.Width + resizeImage14.Width, 1440));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();
            image6.Dispose();
            image7.Dispose();
            image8.Dispose();
            image9.Dispose();
            image10.Dispose();
            image11.Dispose();
            image12.Dispose();
            image13.Dispose();
            image14.Dispose();
            image15.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }
        public static bool combineFor16Images(List<string> fileRoads)
        {
            bool isTrue = false;
            Image image = Image.FromFile(fileRoads[0].ToString());
            Image image2 = Image.FromFile(fileRoads[1].ToString());
            Image image3 = Image.FromFile(fileRoads[2].ToString());
            Image image4 = Image.FromFile(fileRoads[3].ToString());
            Image image5 = Image.FromFile(fileRoads[4].ToString());
            Image image6 = Image.FromFile(fileRoads[5].ToString());
            Image image7 = Image.FromFile(fileRoads[6].ToString());
            Image image8 = Image.FromFile(fileRoads[7].ToString());
            Image image9 = Image.FromFile(fileRoads[8].ToString());
            Image image10 = Image.FromFile(fileRoads[9].ToString());
            Image image11 = Image.FromFile(fileRoads[10].ToString());
            Image image12 = Image.FromFile(fileRoads[11].ToString());
            Image image13 = Image.FromFile(fileRoads[12].ToString());
            Image image14 = Image.FromFile(fileRoads[13].ToString());
            Image image15 = Image.FromFile(fileRoads[14].ToString());
            Image image16 = Image.FromFile(fileRoads[15].ToString());


            var resizeImage1 = ImageResize.ResizeImage(image, 300, 450);
            var resizeImage2 = ImageResize.ResizeImage(image2, 300, 450);
            var resizeImage3 = ImageResize.ResizeImage(image3, 300, 450);
            var resizeImage4 = ImageResize.ResizeImage(image4, 300, 450);
            var resizeImage5 = ImageResize.ResizeImage(image5, 300, 450);
            var resizeImage6 = ImageResize.ResizeImage(image6, 300, 450);
            var resizeImage7 = ImageResize.ResizeImage(image7, 300, 450);
            var resizeImage8 = ImageResize.ResizeImage(image8, 300, 450);
            var resizeImage9 = ImageResize.ResizeImage(image9, 300, 450);
            var resizeImage10 = ImageResize.ResizeImage(image10, 300, 450);
            var resizeImage11 = ImageResize.ResizeImage(image11, 300, 450);
            var resizeImage12 = ImageResize.ResizeImage(image12, 300, 450);
            var resizeImage13 = ImageResize.ResizeImage(image13, 300, 450);
            var resizeImage14 = ImageResize.ResizeImage(image14, 300, 450);
            var resizeImage15 = ImageResize.ResizeImage(image15, 300, 450);
            var resizeImage16 = ImageResize.ResizeImage(image16, 300, 450);

            resizeImage1.MakeTransparent();
            resizeImage2.MakeTransparent();
            resizeImage3.MakeTransparent();
            resizeImage4.MakeTransparent();
            resizeImage5.MakeTransparent();
            resizeImage6.MakeTransparent();
            resizeImage7.MakeTransparent();
            resizeImage8.MakeTransparent();
            resizeImage9.MakeTransparent();
            resizeImage10.MakeTransparent();
            resizeImage11.MakeTransparent();
            resizeImage12.MakeTransparent();
            resizeImage13.MakeTransparent();
            resizeImage14.MakeTransparent();
            resizeImage15.MakeTransparent();
            resizeImage16.MakeTransparent();


            int width = 1200;
            int height = Math.Max(240, 1800);

            Bitmap resultImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultImage);

            graphics.Clear(Color.White);
            graphics.DrawImage(resizeImage1, new Point(0, 0));
            graphics.DrawImage(resizeImage2, new Point(resizeImage1.Width, 0));
            graphics.DrawImage(resizeImage3, new Point(resizeImage1.Width + resizeImage2.Width, 0));
            graphics.DrawImage(resizeImage4, new Point(resizeImage1.Width + resizeImage2.Width + resizeImage3.Width, 0));
            graphics.DrawImage(resizeImage5, new Point(0, 450));
            graphics.DrawImage(resizeImage6, new Point(resizeImage5.Width, 450));
            graphics.DrawImage(resizeImage7, new Point(resizeImage5.Width + resizeImage6.Width, 450));
            graphics.DrawImage(resizeImage8, new Point(resizeImage5.Width + resizeImage6.Width + resizeImage7.Width, 450));
            graphics.DrawImage(resizeImage9, new Point(0, 900));
            graphics.DrawImage(resizeImage10, new Point(resizeImage9.Width, 900));
            graphics.DrawImage(resizeImage11, new Point(resizeImage9.Width + resizeImage10.Width, 900));
            graphics.DrawImage(resizeImage12, new Point(resizeImage9.Width + resizeImage10.Width + resizeImage11.Width, 900));
            graphics.DrawImage(resizeImage13, new Point(0, 1350));
            graphics.DrawImage(resizeImage14, new Point(resizeImage13.Width, 1350));
            graphics.DrawImage(resizeImage15, new Point(resizeImage13.Width + resizeImage14.Width, 1350));
            graphics.DrawImage(resizeImage16, new Point(resizeImage13.Width + resizeImage14.Width + resizeImage15.Width, 1350));

            graphics.Dispose();
            image.Dispose();
            image2.Dispose();
            image3.Dispose();
            image4.Dispose();
            image5.Dispose();
            image6.Dispose();
            image7.Dispose();
            image8.Dispose();
            image9.Dispose();
            image10.Dispose();
            image11.Dispose();
            image12.Dispose();
            image13.Dispose();
            image14.Dispose();
            image15.Dispose();
            image16.Dispose();


            var result = SaveFileDialofForImage(resultImage);

            if (result)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }
        private static bool SaveFileDialofForImage(Bitmap image)
        {
            bool result = false;
            SaveFileDialog saveNewImage = new SaveFileDialog();
            saveNewImage.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Jpeg;

            switch (saveNewImage.ShowDialog())
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    string ext = System.IO.Path.GetExtension(saveNewImage.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    image.Save(saveNewImage.FileName, format);
                    result = true;
                    break;
                case DialogResult.Cancel:
                    result = false;
                    break;
                case DialogResult.Abort:
                    result = false;
                    break;
                case DialogResult.Retry:
                    result = false;
                    break;
                case DialogResult.Ignore:
                    result = false;
                    break;
                case DialogResult.Yes:
                    result = false;
                    break;
                case DialogResult.No:
                    result = false;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
