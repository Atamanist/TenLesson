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

namespace TenLesson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            
        TelegramMessageClient client;

           
        public MainWindow()
           
        {
            InitializeComponent();
            //logList.ItemsSource = client.BotMessageLog;
            SendPanel.Visibility = Visibility.Collapsed;
            FilesPanel.Visibility = Visibility.Collapsed;
        }

         
        private void btnMsgSendClick(object sender, RoutedEventArgs e)
        {
            client.SendMessage(txtMsgSend.Text, TargetSend.Text);
        }

        private void btnTokkenPatchSendClick(object sender, RoutedEventArgs e)
        {
                try
                {
                    client = new TelegramMessageClient(this, txtTokkenPatchSend.Text);
                }
                catch
                {
                    TargetTokkenPatch.Text = "Wrong path or tokken";
                }
        }

        private void btnFilesPatchSendClick(object sender, RoutedEventArgs e)
        {
            bool r = true;
            while (r)
            {
                try
                {

                    client = new TelegramMessageClient(this, txtTokkenPatchSend.Text);

                    r = false;
                }
                catch
                {
                    TargetTokkenPatch.Text = "Wrong path or tokken";
                }
            }

        }
    }
}
