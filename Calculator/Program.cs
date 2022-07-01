using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//تم عمل المشروع بواسطة محمد ياسر
//رابط السلسلة أشرح فيها بالكامل كيف عملت المشروع
//https://www.youtube.com/watch?v=tNf97hymK_w&list=PLsXQEsz9IQ-q-l05rrZwjRnX3SCzGKDJZ
//رابط القناة
//https://www.youtube.com/channel/UCyK_zVDWCutbm8Ji_m3QDWQ
namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
