using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class Configuracion : INotifyPropertyChanged
    {
        private string ajusteImagen;
        private string fondo;

        public string AjusteImagen
        {
            get { return ajusteImagen; }
            set
            {
                if(ajusteImagen != value)
                {
                    ajusteImagen = value;
                    NotifyPropertyChanged("AjusteImagen");
                }
            }
        }

        public string Fondo
        {
            get { return fondo; }
            set
            {
                if(fondo != value)
                {
                    fondo = value;
                    NotifyPropertyChanged("Fondo");
                }
            }
        }
        
        public Configuracion()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
