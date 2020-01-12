using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaseLibrary
{
    public class BaseButton : Button
    {
        #region ADD PROPERTY SOURCE IMAGE
        private Image _srcImage;
        /// <summary>
        /// Choose source image for 3 state of button (normal, hover, click)
        /// </summary>
        public Image SrcImage
        {
            get
            {
                return _srcImage;
            }

            set
            {
                _srcImage = value;
                Invalidate();
            }
        }
        #endregion

        #region VARIABLE
        private int w, h;
        private bool firstPaint;
        private Bitmap currImage;
        private Graphics cutFrame;
        private Rectangle rectDown;
        private Rectangle rectHover;
        private Rectangle rectNormal;
        #endregion

        public BaseButton()
        {
            //Firt load button call DrawFrame
            firstPaint = true;
        }

        /// <summary>
        /// Draw 3 frames for 3 states of button
        /// </summary>
        private void DrawFrame()
        {
            w = SrcImage.Width;
            h = SrcImage.Height / 3;
            rectNormal = new Rectangle(0, 0, w, h);
            rectHover = new Rectangle(0, h, w, h);
            rectDown = new Rectangle(0, h * 2, w, h);
            ChangeFrame(rectNormal);
            firstPaint = false;
        }

        /// <summary>
        /// Change state of button
        /// </summary>
        /// <param name="rect">A state of button</param>
        private void ChangeFrame(Rectangle rect)
        {
            try
            {
                if (SrcImage != null)
                {
                    FlatAppearance.MouseDownBackColor = Color.Transparent;
                    FlatAppearance.MouseOverBackColor = Color.Transparent;
                    currImage = new Bitmap(w, h);
                    cutFrame = Graphics.FromImage(currImage);
                    cutFrame.DrawImage(SrcImage, new Rectangle(0, 0, w, h), rect, GraphicsUnit.Pixel);
                    Invalidate();
                }
            }
            catch { }
        }

        #region CHANGE FRAME WITH STATE OF BUTTON
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            ChangeFrame(rectHover);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            ChangeFrame(rectNormal);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            ChangeFrame(rectDown);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            ChangeFrame(rectNormal);
        }
        #endregion

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            //If have a source image
            if (SrcImage != null)
            {
                //Firt load it draw 3 frames
                if (firstPaint)
                    DrawFrame();
                Width = w;
                Height = h;
                //Then set background with a state frame
                BackgroundImage = currImage;
            }
        }
    }
}
