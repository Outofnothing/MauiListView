using System.Collections.ObjectModel;

namespace MauiApp1
{
    public class ViewModel 
    {
        public ObservableCollection<Type> Types { get; set; } = new()
        {
            typeof(string), typeof(int), typeof(float)
        };
    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel();
        }
    }
}