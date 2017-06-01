/*
    Copyright 2016,2017 Sergey Potemkin
    This file is part of the DOR.
   (Diagnosis of Retina)
   DOR is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License v3.0.
    
    You should have received a copy of the GNU General Public License v3.0
    along with DOR.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DiagnosisOfRetinal
{
    class PictureBoxScroll
    {
        private PictureBox ShotBox;
        private static float ScrollValue = 0.1F;
        private float Scale = 1.0F;
        private Image image;
        private Image originalImage;
        private float maxZoom = 2.0F;
        private float minZoom = 0.7F;

        public PictureBoxScroll(PictureBox box)
        {
            ShotBox = box;
        }


        public void setFrameImage(Image img)
        {

            ShotBox.Image = img;
            image = img;
            originalImage = img;
            Scale = 1.0F;
            ShotBox.Width = 754;
            ShotBox.Height = 372;
        }

        public void resetFrameImage()
        {
            Scale = 1.0F;
            ShotBox.Image = originalImage;
            ShotBox.Width = 754;
            ShotBox.Height = 372;
        }

        public void OnMouseWheel(MouseEventArgs mea)
        {
            ShotBox.Focus();
            if (ShotBox.Focused == true && mea.Delta != 0)
            {
                //ZoomScroll(mea.Location, mea.Delta > 0);
            }
        }

        Graphics ZoomInGraphics;

        public void ZoomIn()
        //private void ZoomScroll(Point location, bool zoomIn)
        {
            int x;
            int y;

            if (image != null && Scale < maxZoom)
            {

                Scale += ScrollValue;
                Size nSize = new Size(Convert.ToInt32(image.Width * Scale), Convert.ToInt32(image.Height * Scale));
                Image gdi = new Bitmap(nSize.Width, nSize.Height);
                ZoomInGraphics = Graphics.FromImage(gdi);
                ShotBox.Size = nSize;
                ZoomInGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
                ZoomInGraphics.DrawImage(image, new Rectangle(new Point(0, 0), nSize), new Rectangle(new Point(0, 0), image.Size), GraphicsUnit.Pixel);
                ShotBox.Image = gdi;
            }
        }

        public void ZoomOut()
        {
            if (image != null && Scale > minZoom)
            {
                Scale -= ScrollValue;
                Size nSize = new Size(Convert.ToInt32(image.Width * Scale), Convert.ToInt32(image.Height * Scale));
                Image gdi = new Bitmap(nSize.Width, nSize.Height);
                ZoomInGraphics = Graphics.FromImage(gdi);
                ShotBox.Size = nSize;
                ZoomInGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
                ZoomInGraphics.DrawImage(image, new Rectangle(new Point(0, 0), nSize), new Rectangle(new Point(0, 0), image.Size), GraphicsUnit.Pixel);
                ShotBox.Image = gdi;
            }
        }

    }
}
