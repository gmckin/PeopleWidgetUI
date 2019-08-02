using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

namespace PeopleWidgetUI.Client
{    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static HttpClient peopleClient = new HttpClient();


        // if using a webapi to serve data to the client.
        private void InitializeClients()
        {
            peopleClient.BaseAddress = new Uri("");
            peopleClient.DefaultRequestHeaders.Accept.Clear();
            peopleClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("appliaction/json"));
        }

        //Otherwise, connect it to an WCF via reference.
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
