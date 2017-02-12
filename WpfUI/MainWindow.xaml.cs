using System.Windows;
using CalculatorApp;

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Calculator c = new Calculator();
            // Capture scenario: what if the user enters non integers, do validation...
            c.FirstArgument = int.Parse(TextBoxFirstArgument.Text);
            c.SecondArgument = int.Parse(TextBoxSecondArgument.Text);
            TextBoxResult.Text = c.Add().ToString();
        }
    }
}
