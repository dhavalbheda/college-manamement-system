using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace AD_CMS
{
    public class ClassCall
    {
        public static MainForm mainFormObj;

        public ClassCall(MainForm mfm)
        {
            mainFormObj = mfm;
        }
        public static void textChangeFun(Control ctr)
        {
            ctr.BackColor = Color.White;
        }

        public static void openHomePage()
        {
            mainFormObj.HomeCall();
        }
    }
}
