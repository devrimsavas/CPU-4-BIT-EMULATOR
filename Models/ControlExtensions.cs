using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public static class ControlExtensions
    {
        public static void EnableDoubleBuffered(this Control control, bool setting)
        {
            PropertyInfo pi= typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi?.SetValue(control, setting, null);
        }
    }
}
