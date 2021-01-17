using System.ComponentModel;

namespace ChatBot.Clases
{
    class Mensaje : INotifyPropertyChanged
    {
        // Propiedades
        private string _texto;
        private Emisor _emisor;

        public string Texto
        {
            get { return _texto; }
            set
            {
                _texto = value;
                NotifyPropertyChanged("Texto");
            }
        }

        public Emisor Emisor
        {
            get { return _emisor; }
            set
            {
                _emisor = value;
                NotifyPropertyChanged("Emisor");
            }
        }

        // Constructores
        public Mensaje(Emisor emisor)
        {
            Texto = "";
            Emisor = emisor;
        }

        public Mensaje(string texto, Emisor emisor)
        {
            Texto = texto;
            Emisor = emisor;
        }

        //Implementación de la interfaz INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // ToString
        public override string ToString()
        {
            return $"{Emisor}\n" +
                   $"{Texto}";
        }
    }
}
