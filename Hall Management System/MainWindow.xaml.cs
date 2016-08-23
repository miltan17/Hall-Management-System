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
using System.Xml;
using System.IO;

namespace Hall_Management_System
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        private void form_Loaded_1(object sender, RoutedEventArgs e)
        {
            doc.Load("students.xml");
        }
        
        private void AddStudentButton(object sender, RoutedEventArgs e)
        {
            AddWindow Add = new AddWindow();
            Add.Show();
        }

        private void StudentInfoButton(object sender, RoutedEventArgs e)
        {
            InfoWindow Info = new InfoWindow();
            Info.Show();
        }

        private void EditInfoButton(object sender, RoutedEventArgs e)
        {
            EditWindow edit = new EditWindow();
            edit.Show();
        }

        private void RemoveInfoButton(object sender, RoutedEventArgs e)
        {
            RemoveWindow remove = new RemoveWindow();
            remove.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
           
        }

      
    }
}
