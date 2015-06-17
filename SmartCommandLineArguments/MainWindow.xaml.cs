using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartCommandLineArguments
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, string> arguments = new Dictionary<string, string>(); 
        public MainWindow()
        {
            InitializeComponent();
            string[] args = Environment.GetCommandLineArgs();

            for (int index = 1; index < args.Length; index += 2)
            {
                string arg = args[index].Replace("--", "");
                arguments.Add(arg, args[index + 1]);
            }

            if (arguments.ContainsKey("message"))
            {
                txtMessage.Text = arguments["message"];
            }
        }
    }
}
