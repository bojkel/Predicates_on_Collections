﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicates_on_Collections
{
    class Program
    {
        public delegate List<Person> addPeople (Person person, Job job);


        static void Main(string[] args)
        {
            Job job = new Job("location","description",10);
            Person Bozhidar = new Person("firstname","lastname",job);

            Bozhidar.generate_PeopleList();
            Bozhidar.getAllPeople();
            Console.ReadKey();
        }
    }
}
