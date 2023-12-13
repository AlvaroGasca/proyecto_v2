using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.dto
{
    public class Logica
    {
        public ObservableCollection<Cita> ListaCita { get; set; }

        public Logica()
        {
            ListaCita = new ObservableCollection<Cita>();
            ListaCita.Add(new Cita("Pepe", "Gutierrez", "Si", DateTime.Now, "Sevilla", "sala 3"));
        }

        public void AgregarCita(Cita cita)
        {
            ListaCita.Add(cita);
        }

        public void EliminarCita(int index)
        {
            if (index >= 0 && index < ListaCita.Count)
            {
                ListaCita.RemoveAt(index);
            }
        }

        public void EditarCita(int index, Cita nuevaCita)
        {
            if (index >= 0 && index < ListaCita.Count)
            {
                ListaCita[index] = nuevaCita;
            }
        }
    }
}

