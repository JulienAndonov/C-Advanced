using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class Repository
    {
        private int UID { get; set; }
        private Dictionary<int, Person> RepositoryData;
        public int Count { get; private set; }



        public Repository()
        {
            this.RepositoryData = new Dictionary<int, Person>();
            this.UID = 0;
            this.Count = 0;
        }


        public void Add(Person person)
        {
            this.RepositoryData.Add(UID, person);
            this.UID++;
            this.Count++;
        }

        public Person Get(int id)
        {
            return this.RepositoryData.FirstOrDefault(t => t.Key == id).Value;
        }


        public bool Update(int id, Person newPerson)
        {
            if (!this.RepositoryData.ContainsKey(id))
            {
                return false;
            }

            this.RepositoryData[id] = newPerson;
            return true;
        }

        public bool Delete(int id)
        {
            if (!this.RepositoryData.ContainsKey(id))
            {
                return false;
            }

            this.RepositoryData.Remove((id));
            this.Count--;
            return true;
        }
    }
}
