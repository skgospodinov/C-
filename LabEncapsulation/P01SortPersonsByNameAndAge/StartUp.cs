using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputData = Console.ReadLine().Split();
                Person person = new Person(inputData[0], inputData[1], int.Parse(inputData[2]), decimal.Parse(inputData[3]));
                people.Add(person);
            }


            //people.ForEach(p => Console.WriteLine(p.ToString()));
            Team team = new Team("SoftuniTeam");

            people.ForEach(p => team.AddPlayer(p));
            Console.WriteLine($"First team: {team.FirstTeam.Count}");
            Console.WriteLine($"Reserve team: { team.ReserveTeam.Count}");
        }
    }
}
