using System;
using System.Collections.Generic;
using System.Linq;


namespace HelloSofiia
{
    public class ProgramForRegistration
    {
        public static void Start()
        {
            // TODO: Implement both approaches and compare results

            // Part A: Using List<string>
            List<string> studentsWithList = new List<string>();

            // Part B: Using HashSet<string>
            HashSet<string> studentsWithHashSet = new HashSet<string>();

            // Test data - some students try to register multiple times
            string[] registrationAttempts = {
            "Alice", "Bob", "Charlie", "Alice",
            "Diana", "Bob", "Eve", "Charlie", "Alice"
        };
            //Add all registration attempts to 'studentsWithList'
            studentsWithList.AddRange(registrationAttempts);

            //Print  the contents of 'studentsWithList'
            for (int i = 0; i < studentsWithList.Count; i++)
            {
                Console.Write(studentsWithList[i] + ", ");
            }
            Console.WriteLine();

            //Print the count of 'studentsWithList'
            Console.WriteLine(studentsWithList.Count);

            //Add all registration attempts to 'studentsWithHashSet'
            for (int i = 0; i < registrationAttempts.Length; i++)
            {
                studentsWithHashSet.Add(registrationAttempts[i]);
            }

            //Print  the contents of 'studentsWithHashSet'
            foreach (string name in studentsWithHashSet)
            {
                Console.Write(name + ", ");
            }

            //Print the count of 'studentsWithHashSet'
            Console.WriteLine();
            Console.WriteLine(studentsWithHashSet.Count);
        }
    }
}
