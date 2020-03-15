using System.Windows;
using System.Windows.Controls;

namespace EventSample.Views
{
    /// <summary>
    /// Interaction logic for CodeBehind
    /// </summary>
    public partial class CodeBehind : UserControl
    {
        public CodeBehind()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
        }

        private void textBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            textBlock.Text += e.Text;
        }
    }
}
