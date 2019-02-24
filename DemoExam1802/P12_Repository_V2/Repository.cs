using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private List<Person> data;

        public int Count
        {
            get { return this.data.Count; }
        }

        public Repository()
        {
            this.data = new List<Person>();
            
        }

        public void Add(Person person)
        {
            this.data.Add(person);
        }

        public Person Get(int id)
        {
            return this.data[id];
        }


        public bool Update(int id, Person newPerson)
        {
            if (id >= this.data.Count)
            {

                return false;

            }

            this.data[id] = newPerson;
            return true;

        }

        public bool Delete(int id)
        {
            if (id >= this.data.Count)
            {

                return false;

            }
            this.data.RemoveAt(id);
            return true;
        }



    }
}
