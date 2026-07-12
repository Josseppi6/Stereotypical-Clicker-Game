using System.Windows;
using Stereotypical_Clicker_Game.ClickHandler;

namespace Stereotypical_Clicker_Game
{
    public partial class MainWindow : Window
    {
        // Create a single instance of your handler
        private ClickHandler.ClickHandler _clickHandler = new ClickHandler.ClickHandler();

        public MainWindow()
        {
            InitializeComponent();
        }

        // This method automatically runs when the XAML button is clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _clickHandler.ProcessClick();
        }
    }
}
