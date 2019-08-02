using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleWidgetUI.Client
{
    public class Person   
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Gender { get; set; }        
    }

    public class PersonVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Gender { get; set; }      
    }

    public class BatchMapper
    {
        public PersonVM MapToBatch(Person person)
        {
            var personvm = new PersonVM();
            personvm.FirstName = person.FirstName;
            personvm.LastName = person.LastName;
            personvm.DateOfBirth = person.DateOfBirth;
            personvm.Gender = person.Gender;
            var c = new Person();
            
            return personvm;
        }
    }
}
