using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class DllImport
    {
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetAsyncKeyState(int vKey);
    }
}
