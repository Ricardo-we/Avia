using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaApp.Utils
{
    internal class FormUtils
    {
        public static void OnFormClosing(Form form)
        {
            form.Dispose();
            Application.ExitThread();
        }
    }
}
