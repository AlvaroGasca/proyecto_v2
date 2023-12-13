using System;
using System.ComponentModel;

namespace proyecto.dto
{
    public class Cita : INotifyPropertyChanged, IDataErrorInfo
    {
        private string nombre;
        private string apellidos;
        private string grupo;
        private DateTime fecha;
        private string ciudad;
        private string sala;

        public Cita()
        {
            Grupo = "Si";
            Fecha = DateTime.Now;
            Sala = "Sala 1";
        }
        public Cita(string nombre, string apellidos, string grupo, DateTime fecha, string ciudad, string sala)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Grupo = grupo;
            Fecha = fecha;
            Ciudad = ciudad;
            Sala = sala;
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                if (apellidos != value)
                {
                    apellidos = value;
                    OnPropertyChanged(nameof(Apellidos));
                }
            }
        }

        public string Grupo
        {
            get { return grupo; }
            set
            {
                if (grupo != value)
                {
                    grupo = value;
                    OnPropertyChanged(nameof(Grupo));
                }
            }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set
            {
                if (fecha != value)
                {
                    fecha = value;
                    OnPropertyChanged(nameof(Fecha));
                }
            }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set
            {
                if (ciudad != value)
                {
                    ciudad = value;
                    OnPropertyChanged(nameof(Ciudad));
                }
            }
        }

        public string Sala
        {
            get { return sala; }
            set
            {
                if (sala != value)
                {
                    sala = value;
                    OnPropertyChanged(nameof(Sala));
                }
            }
        }

        public int errores = 0;

        public string this[string columnName]
        {
            get
            {
                string result = null;

                switch (columnName)
                {
                    case "Nombre":
                        if (string.IsNullOrEmpty(Nombre))
                            result = "Debe introducir el nombre";
                        break;

                    case "Apellidos":
                        if (string.IsNullOrEmpty(Apellidos))
                            result = "Debe introducir los apellidos";
                        break;


                    default:
                        break;
                }

                return result;
            }
        }

        public string Error => null;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
