using System.Drawing;

namespace DJ.UserControls
{
    public static class FormHelper
    {
        public static Bitmap ChangeColor(Bitmap scrBitmap, string status)
        {
            Color newColor;
            if (status == "click")
            {
                newColor = Color.White;
            }
            else
            {
                newColor = Color.Black;
            }

            Color actulaColor;
            //make an empty bitmap the same size as scrBitmap
            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    actulaColor = scrBitmap.GetPixel(i, j);
                    // > 150 because.. Images edges can be of low pixel color. if we set all pixel color to new then there will be no smoothness left.
                    newBitmap.SetPixel(i, j, actulaColor.A > 150 ? newColor : actulaColor);
                }
            }
            return newBitmap;
        }
    }
}
