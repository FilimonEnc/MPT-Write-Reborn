using DomainLair.DataBase.Entity;
using DomainLair.DataBase;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows;

namespace MPT_Write_Reborn.Forms
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Write_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            Repository.Delete<SubjectTeacherEntity>(x => true);
            Repository.Delete<GroupTeacherEntity>(x => true);
            Repository.Delete<SubjectEntity>(x => true);
            Repository.Delete<GroupEntity>(x => true);
            Repository.Delete<TeacherEntity>(x => true);
        }
            
    }
}
