using System.Windows.Input;

namespace ChatBot.Clases
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand New = new RoutedUICommand
            (
                "Nuevo",
                "New",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    // Atajo con el teclado (Ctrl + N)
                    new KeyGesture(Key.N, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Save = new RoutedUICommand
            (
                "Guardar",
                "Save",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    // Atajo con el teclado (Ctrl + G)
                    new KeyGesture(Key.G, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Config = new RoutedUICommand
            (
                "Ajustes",
                "Config",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    // Atajo con el teclado (Ctrl + C)
                    new KeyGesture(Key.C, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Exit = new RoutedUICommand
            (
                "Salir",
                "Exit",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    // Atajo con el teclado (Ctrl + S)
                    new KeyGesture(Key.S, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Check = new RoutedUICommand
            (
                "Check",
                "Check",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    // Atajo con el teclado (Ctrl + O)
                    new KeyGesture(Key.O, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Send = new RoutedUICommand
            (
                "Enviar",
                "Send",
                typeof(CustomCommands),
                new InputGestureCollection
                {
                    new KeyGesture(Key.Enter)
                }
            );
    }
}
