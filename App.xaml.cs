using System;
using System.Windows;

namespace proyecto
{
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            //App app = new App();
            //Formulario formulario = new Formulario(); 
            //app.Run(formulario);
            App app = new App();
            Citas citas = new Citas();
            app.Run(citas);
        }
    }
}

