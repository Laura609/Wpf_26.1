using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_26._1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //if (System.IO.File.Exists("file.txt"))
            //{
            //    string xaml = System.IO.File.ReadAllText("file.txt");
            //    object content = System.Windows.Markup.XamlReader.Parse(xaml);
            //    this.Content = content;
            //}
        }

        //protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        //{
        //    base.OnClosing(e);
        //    string xaml = System.Windows.Markup.XamlWriter.Save(this.Content);
        //    System.IO.File.WriteAllText("file.txt", xaml);
        //}
    }
}
