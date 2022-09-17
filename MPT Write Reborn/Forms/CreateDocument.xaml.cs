using System.Windows;
using System.Windows.Controls;
using WK.Libraries.BetterFolderBrowserNS;

namespace MPT_Write_Reborn.Forms
{

    public partial class CreateDocument : Window
    {
        public CreateDocument()
        {
            InitializeComponent();
        }

        private void OpenFolder(Label label)
        {
            BetterFolderBrowser folderBrowserDialog = new BetterFolderBrowser();
            if (folderBrowserDialog.ShowDialog() == System.Window.Forms.DialogResult.Cancel)
                return;
            string filename = folderBrowserDialog.SelectedPath;
            label.Content = filename;
        }
        private void AddFolderNagruzok_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

//Repository.Create(new SubjectEntity()
//{
//    Subject = "huy"
//            });
//var t = Repository.Get<SubjectEntity>(x => x.Subject == "huy");
//Repository.Delete<SubjectEntity>(x => x.Subject == "huy");
//Repository.Delete<SubjectEntity>(x => x.Subject == "zalupa");