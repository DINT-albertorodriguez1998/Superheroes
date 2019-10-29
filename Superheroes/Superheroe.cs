using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class Superheroe : INotifyPropertyChanged
    {
        private string nombre;
        private string enemigo;
        private string foto;
        private bool vengador;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if(nombre != value)
                {
                    nombre = value;
                    NotifyPropertyChanged("Nombre");
                }
            }
        }

        public string Enemigo
        {
            get { return enemigo; }
            set
            {
                if(enemigo != value)
                {
                    enemigo = value;
                    NotifyPropertyChanged("Enemigo");
                }
            }
        }
        
        public string Foto
        {
            get { return foto; }
            set
            {
                if(foto != value)
                {
                    foto = value;
                    NotifyPropertyChanged("Foto");
                }
            }
        }

        public bool Vengador
        {
            get { return vengador; }
            set
            {
                if(vengador != value)
                {
                    vengador = value;
                    NotifyPropertyChanged("Vengador");
                }
            }
        }

        public Superheroe()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static Superheroe GetSample()
        {
            Superheroe heroe = new Superheroe();
            heroe.Nombre = "Daredevil";
            heroe.Enemigo = "Kingping";
            heroe.Foto = @"https://dam.smashmexico.com.mx/wp-content/uploads/2018/08/27150601/daredevilbio_portada.jpg";
            heroe.Vengador = false;

            return heroe;
        }
    }
}

