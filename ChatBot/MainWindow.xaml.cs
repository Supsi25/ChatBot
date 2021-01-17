using ChatBot.Clases;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace ChatBot
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Mensaje> mensajes;
        public MainWindow()
        {
            InitializeComponent();
            mensajes = new ObservableCollection<Mensaje>();
            listaMensajes.DataContext = mensajes;
        }

        private void New_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mensajes.Clear();
        }

        private void New_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Comprobamos si hay mensajes, si no hay deshabilitamos
            if (listaMensajes != null && 
                listaMensajes.Items.Count > 0)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void Save_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT File (*.txt) |*.txt";

            try
            {
                if (saveFileDialog.ShowDialog() == true)
                    File.WriteAllText(saveFileDialog.FileName, String.Join("\n", mensajes));
            }
            catch (IOException ioEx)
            {
                throw new IOException("Error al guardar el fichero", ioEx);
            }
        }

        private void Save_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Comprobamos si hay mensajes, si no hay deshabilitamos
            if (listaMensajes != null &&
                listaMensajes.Items.Count > 0)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void Config_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ;
        }

        private void Config_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }

        private void Exit_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void Check_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Conexión correcta con el servidor del Bot",
                            "Comprobar conexión",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }

        private void Send_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mensajes.Add(new Mensaje(escribiendoUsuarioTextBox.Text, Emisor.Usuario));
            mensajes.Add(new Mensaje("Lo siento, estoy un poco cansado para hablar", Emisor.Robot));
            escribiendoUsuarioTextBox.Text = "";
        }

        private void Send_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (escribiendoUsuarioTextBox != null &&
                escribiendoUsuarioTextBox.Text != "")
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }
    }
}
