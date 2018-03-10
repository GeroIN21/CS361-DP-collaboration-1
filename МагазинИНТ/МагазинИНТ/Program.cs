using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МагазинИНТ
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TubeDiscountCard tubeCard = new TubeDiscountCard(5, 5000);
            TransistorCard transistorCard = new TransistorCard(10, 12500);
            IntegratedCard integratedCard = new IntegratedCard(15, 25000);

            Cashier cashier = new Cashier();

            Application.Run(new Form1());
        }
    }
}
