using System.Windows;
using SimpleMvvmToolkit.Samples.WPF.Core.ViewModels;
using SimpleMvvmToolkit.Samples.WPF.Core.Views;

namespace SimpleMvvmToolkit.Samples.WPF.Core
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainPageViewModel viewModel, CustomerView customerView)
        {
            DataContext = viewModel;
            InitializeComponent();
            Panel.Children.Add(customerView);
        }
    }
}
