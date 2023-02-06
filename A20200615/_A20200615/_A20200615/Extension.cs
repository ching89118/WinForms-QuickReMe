using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _A20200615
{
    static class Extension
    {

        //這裡全部的擴充方法均為Control類別的擴充方法
        public static void SetCtrlsVisible(this Control control,bool isVisible)
        {            
            control.Invoke((MethodInvoker)delegate {
              
                control.Visible = isVisible;
            });
        }

        public static void ShowCtrlsText(this Control control,string text)
        {            
            control.Invoke((MethodInvoker)delegate {
                
                control.Text = text;
            });
        }

        public static void setCtrlsEnable(this Control control,bool isEnable)
        {
            control.Invoke((MethodInvoker)delegate {

                control.Enabled = isEnable;
            });
        }

        public static void setCtrlsForeCr(this Control control,Color foreColor)
        {
            control.Invoke((MethodInvoker)delegate {

                control.ForeColor = foreColor;
            });
        }

        public static bool IsEmail(this string input)
        {
            if (input.Contains('@') && input.Contains(".com"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
