using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNember1
{
    public class Actor
    {
        // תכונות פרטיות בלבד
        private int id;
        private int age;
        private int numberOfShows;

        public Actor(int id, int age)
        {
            this.id = id;
            this.age = age;
            this.numberOfShows =0;
        }

        public int GetAge()
        {
            return this.age;
        }   
        public int GetNumberOfShows()
        {
            return this.numberOfShows;
        }

        public void AddShow()
        {
            this.numberOfShows++;
        }



    }
    
}
