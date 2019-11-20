using System.Windows.Controls;
using SimpleMvvmToolkit.Samples.WPF.Core.ViewModels;

namespace SimpleMvvmToolkit.Samples.WPF.Core.Views
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        public CustomerView(CustomerViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
