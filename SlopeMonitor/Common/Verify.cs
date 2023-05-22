using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// These codes are used to generate verify code
/// Please do not change it
/// </summary>
namespace SlopeMonitor.Common
{
    #region Create verify code
    public class Verify : CommonConst
    {
        private int _codeCount = CodeCounts;
        /// <summary>
        /// Create verify code
        /// </summary>
        /// <returns></returns>
        public int CodeCount
        {
            set
            {
                _codeCount = value <= 0 ? _codeCount : value;
            }
        }
        /// <summary>
        /// verify code
        /// </summary>
        private string _checkCode = string.Empty;
        public string CheckCode
        {
            get
            {
                return _checkCode;
            }
        }
        private int _bitmapWidth = BitMapW;
        public int BitMapWidth
        {
            set
            {
                _bitmapWidth = value <= 0 ? _bitmapWidth : value;
            }
        }
        private int _bitmapHeight = BitMapH;
        public int BitMapHeight
        {
            set
            {
                _bitmapHeight = value <= 0 ? _bitmapHeight : value;
            }
        }
        private string _fontName = FTName;
        public string FontName
        {
            set
            {
                _fontName = string.IsNullOrEmpty(value) ? _fontName : value;
            }
        }
        private int _fontSize = FtSize;
        public int FontSize
        {
            set
            {
                _fontSize = value <= 0 ? _fontSize : value;
            }
        }
        public Bitmap CreateVerfiyCode()
        {
            // Create verify code
            string sCode = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                sCode += Allchar.Substring(rnd.Next(0, Allchar.Length), 1);
            }
            _checkCode = sCode;
            Bitmap bitmap = new Bitmap(_bitmapWidth, _bitmapHeight);
            Graphics graphics = Graphics.FromImage(bitmap);
            Font font = new Font(_fontName, _fontSize, FontStyle.Regular);
            Brush brush = new SolidBrush(Color.Green);
            graphics.Clear(ColorTranslator.FromHtml("#eff8e8"));
            SizeF charSize;
            PointF pointF = new PointF(0, 5);
            float sepDistance = 0.5F;
            char[] vs = sCode.ToCharArray();
            for (int i = 0; i < vs.Length; i++)
            {
                string sChar = vs[i].ToString();
                charSize = graphics.MeasureString(sChar, font);
                graphics.DrawString(sChar, font, brush, pointF);
                pointF.X += charSize.Width + sepDistance;
            }
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Jpeg);
            return bitmap;
        }
    }
    #endregion
}
