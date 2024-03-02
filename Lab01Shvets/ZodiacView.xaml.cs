using Lab01Shvets.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Lab01Shvets
{
    /// <summary>
    /// Interaction logic for ZodiacView.xaml
    /// </summary>
    public partial class ZodiacView : Window
    {
        private readonly ZodiacViewModel _viewModel;
        public ZodiacView()
        {
            InitializeComponent();
            DataContext = _viewModel = new ZodiacViewModel();
        }

        private void DateChoice_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DateChoice.SelectedDate.HasValue)
                _viewModel.BirthDate = DateChoice.SelectedDate.Value;
        }
    }
}