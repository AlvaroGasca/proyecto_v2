using proyecto.dto;
using System.Windows;
using System.Windows.Controls;

namespace proyecto
{
    public partial class Formulario : Window
    {
        private Cita _cita;
        private int index;

        public Formulario()
        {
            InitializeComponent();
            _cita = new Cita();
            DataContext = _cita;
        }

        public Formulario(int index)
        {
            InitializeComponent();
            this.index = index;
            this._cita = new Cita();
            this.DataContext = Citas.logica.ListaCita[index];
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            if (_cita.errores == 0)
            {
                MessageBox.Show("Cita agregada correctamente");
                Close(); 
            }
            else
            {
                MessageBox.Show("Por favor, corrija los errores antes de agregar la cita");
            }
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Operación cancelada");
            Close(); 
        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                _cita.errores++;
            else
                _cita.errores--;

            ButtonAceptar.IsEnabled = _cita.errores == 0;
        }
    }
}
