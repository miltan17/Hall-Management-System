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
using System.Xml;
using System.IO;


namespace Hall_Management_System
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();

        }

        XmlDocument doc = new XmlDocument();
        private void Info(object sender, RoutedEventArgs e)
        {
            doc.Load("students.xml");
        }

        private void OkButtonInInfoWIndow(object sender, RoutedEventArgs e)
        {
            
                XmlElement element = doc.GetElementById(TextboxInInfoWindow.Text);
                if (element != null)
                {
                    Student_Information StdInfo = new Student_Information();
                    StdInfo.Show();
                }
                else
                    MessageBox.Show("Miltan");
           
        }
    }
}
