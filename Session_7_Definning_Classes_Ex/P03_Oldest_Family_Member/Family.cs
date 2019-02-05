using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> listofPeople;

        public List<Person> ListOfPeople
        {
            get { return this.listofPeople; }
            set { this.listofPeople = value; }
        }

        public Family(List<Person> newPeople)
        {
            this.ListOfPeople = newPeople;
        }


        public void AddMember(Person person)
        {
            this.ListOfPeople.Add(person);
        }


        public Person GetOldestMember()
        {
            var olderPerson = ListOfPeople.OrderByDescending(x => x.Age).First();
            return olderPerson;
        }






    }
}
