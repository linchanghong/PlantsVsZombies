using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace plantsVSzombies
{
    class PictureEffect
    {
        private ImageAttributes _attributes = new ImageAttributes();

        /// <summary>
        /// 调整透明度
        /// </summary>
        /// <param name="opacity"></param>
        public void ChangeTransparency(Image srcImage, Graphics gbmp, Size bmpSize, double opacity)
        {
            float[][] nArray ={ new float[] {1, 0, 0, 0, 0},
                                new float[] {0, 1, 0, 0, 0},
                                new float[] {0, 0, 1, 0, 0},
                                new float[] {0, 0, 0, (float)opacity, 0},
                                new float[] {0, 0, 0, 0, 1}};
            _attributes.SetColorMatrix(new ColorMatrix(nArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);/*为指定类别设置颜色调整矩阵。newColorMatrix
                                                                                                                  类型： System.Drawing.ImagingColorMatrix
                                                                                                                  颜色调整矩阵。 

                                                                                                                  mode
                                                                                                                  类型： System.Drawing.ImagingColorMatrixFlag
                                                                                                                  ColorMatrixFlag 的元素，它指定将受颜色调整矩阵影响的图像和颜色的类型。 

                                                                                                                  type
                                                                                                                  类型： System.Drawing.ImagingColorAdjustType
                                                                                                                  ColorAdjustType 的一个元素，指定将设置颜色调整矩阵的类别。
                                                                                                                  */
            gbmp.FillRectangle(new SolidBrush(SystemColors.ControlText), 0, 0, bmpSize.Width, bmpSize.Height);//ControlText很重要设置背景色为黑
            gbmp.DrawImage(srcImage, new Rectangle(0, 0, bmpSize.Width, bmpSize.Height),
                           0, 0, srcImage.Width, srcImage.Height, GraphicsUnit.Pixel, _attributes);
        }
    }
}
