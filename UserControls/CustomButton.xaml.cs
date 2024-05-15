using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace WindSpareParts.View.UserControls
{
    public partial class CustomButton : UserControl, INotifyPropertyChanged
    {
        public CustomButton()
        {
            DataContext = this;
            InitializeComponent();
        }

        // Dependency property for changing the button's text
        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.Register("ButtonText", typeof(string), typeof(CustomButton), new PropertyMetadata(""));

        // Property for accessing the button's text
        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        // Event to notify property changes
        public event PropertyChangedEventHandler PropertyChanged;

  

        // Method to raise property changed event
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void btnCustomButton_Click(object sender, RoutedEventArgs e)
        {

            
            var button = (CustomButton)sender;

            
        }
    }
}
