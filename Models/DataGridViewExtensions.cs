using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace WinFormsApp1.Models
{
    public static class DataGridViewExtensions
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting )
        {
            PropertyInfo pi=dgv.GetType().GetProperty("DoubleBuffered",BindingFlags.Instance | BindingFlags.NonPublic);   
            pi?.SetValue(dgv, setting ,null);
        }
    }
}
