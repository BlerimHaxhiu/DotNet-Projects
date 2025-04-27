using System.Windows;
using System.Windows.Controls;

namespace GraphPathfinder
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HomePage());
        }

        private void NavigateToHome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        private void NavigateToGraphEditor_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new GraphEditorPage());
        }

        private void NavigateToAlgorithmVisualizations_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AlgorithmVisualizationsPage());
        }

        private void NavigateToAbout_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AboutPage());
        }
    }
}