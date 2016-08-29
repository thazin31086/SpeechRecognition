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
using System.Windows.Shapes;
using System.Windows.Input;

namespace Ex1
{
    /// <summary>
    /// Interaction logic for Voicekeyboard.xaml
    /// </summary>
    public partial class Voicekeyboard : Window
    {
        public Voicekeyboard()
        {
            InitializeComponent();
        }

        public void Open_Click(object sender, EventArgs e)
        {
            KeyEventArgs args = new KeyEventArgs(Keyboard.PrimaryDevice,

             Keyboard.PrimaryDevice.ActiveSource, 0, Key.BrowserHome);

            args.RoutedEvent = Keyboard.KeyDownEvent;

            InputManager.Current.ProcessInput(args);


        }
        public void Close_Click(object sender, EventArgs e)
        {
            //SendKeys.Send("ALT+F4 ");
        }
        public void ScrollUp_Click(object sender, EventArgs e)
        {
            //SendKeys.Send("UP ARROW");
        }

        public void ScrollDown_Click(object sender, EventArgs e)
        {
            //SendKeys.Send("DOWN ARROW");

        }
    }
}
