using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 *  This class will hold groups of Person objects. The idea is that they can be merged. 
 *  The idea isn't to store 10,000 refugees in it, just small ammounts for quick access.
 *  I.E: A queue to send to a database, Search results
 *  I have many high expectations for a hash table which will hopefully store many more Refugees,
 *  lets not forget that SQL can do alot of the searching (filtering) for us!
 *  */
namespace RefuCate_WPF.Classes
{
    class People
    {

        // Will probably use a better one later
        LinkedList<Person> peopleList;

        public People()
        {
            peopleList = new LinkedList<Person>();
        }

        public LinkedListNode<Person> addPerson(Person p)
        {
            return peopleList.AddLast(p);
        }

        public LinkedList<Person> getList()
        {
            return peopleList;
        }
    }
}
