using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// These codes used to generate verify codes
/// Please do not change these codes.
/// </summary>
namespace SlopeMonitor.Common
{
    public abstract class CommonConst
    {
        #region Verify code string
        protected const string Allchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        #endregion
        protected const int CodeCounts = 5;
        protected const int BitMapW = 84;
        protected const int BitMapH = 28;
        protected const string FTName = "Bahnschrift";
        protected const int FtSize = 14;
    }
}
