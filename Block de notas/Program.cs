using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Block_de_notas
{
    internal static class Program
    {
        private static bool buscClosedStatus = true;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void buscCloseWindow()
        {
            buscClosedStatus = true;
        }

        public static void buscOpenWindow()
        {
            buscClosedStatus = false;
        }

        public static bool buscIsClosed()
        {
            return buscClosedStatus;
        }
    }
}
