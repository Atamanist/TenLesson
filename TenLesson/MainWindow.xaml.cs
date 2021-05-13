using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
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
            client = new TelegramMessageClient(this);
            logList.ItemsSource = client.BotMessageLog;
            MsgBox.Visibility = Visibility.Collapsed;
            FilesBox.Visibility = Visibility.Collapsed;
        }

         
        private void btnMsgSendClick(object sender, RoutedEventArgs e)
        {
            try
            {
                client.SendMessage(txtMsgSend.Text, TargetSend.Text);
            }
            catch
            {
            }
        }

        private void btnTokkenPatchSendClick(object sender, RoutedEventArgs e)
        {
            if (client.ShowTokken(txtTokkenPatchSend.Text))
            {
                TargetTokkenPatch.Text = "Done";
                TokkenBox.Visibility = Visibility.Collapsed;
                FilesBox.Visibility = Visibility.Visible;
            }
            else
            {
                TargetTokkenPatch.Text = "Не правильно задан путь или токкен";
            }
        }

        private void btnFilesPatchSendClick(object sender, RoutedEventArgs e)
        {

            var dialogfolder = new FolderBrowserDialog();
            dialogfolder.ShowDialog();
            client.ShowDaWay(dialogfolder.SelectedPath);
            FilesBox.Visibility = Visibility.Collapsed;
            MsgBox.Visibility = Visibility.Visible;
            client.BotStart();
        }
    }
}
