using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace PeopleWidgetUI.Client
{
    public partial class MainWindow : Window         
    {

        public async Task<List<string>> getPeople()
        {
            HttpResponseMessage response = await peopleClient.GetAsync("./api/people");
            response.EnsureSuccessStatusCode();
            var people = await response.Content.ReadAsAsync<IEnumerable<Person>>();
            List<string> person = new List<string>();


            if (person != null)
            {
                foreach(Person p in people.ToList())
                {
                    person.Add(p.Id);
                }
            }
            return person;
        }

        //private async Task<List<string>addPerson(PersonVM personVM)
        //{

        //    return 
        //}
    }
}
