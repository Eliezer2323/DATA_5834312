using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_5834312
{
    public class Alumnos: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string nombre = string.Empty;

        public string name {
            get => nombre;
             set
            {
                if (nombre == value)
                    return;
                nombre = value;
                onPropertyChanged(nameof(name));
                onPropertyChanged(nameof(MostrarNombre));
            }
        }

        public string MostrarNombre => $"Nombre ingresado: {name}";

        void onPropertyChanged(string nombre)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
