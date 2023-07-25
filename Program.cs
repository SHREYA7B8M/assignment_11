using System;

class Program
{
    public static LargeDataCollection agent { get; private set; }

    static void Main()
    {
        agent = new LargeDataCollection(new string[] { "\nEthan Hunt", "Luther Stickell", "Benji Dunn", "Ilsa Faust", "Alanna Mitsopolis" });
        {

            agent.Add("Eugene Kittridge");
            agent.Add("Jasper Briggs");

            Console.WriteLine("\nAccessing Agents");
            Console.WriteLine(agent[0]);
            Console.WriteLine(agent[1]);
            Console.WriteLine(agent[2]);
            Console.WriteLine(agent[3]);
            //Console.WriteLine(agent[4]);
            //Console.WriteLine(agent[5]);
            //Console.WriteLine(agent[6]);

            agent.Remove("Ilsa Faust");

            Console.WriteLine("\nCollection after removing 'Ilsa Faust':\n");

            Console.WriteLine("Agents Count: " + agent.Count);

            for (int i = 0; i < agent.Count; i++)
            {
                Console.WriteLine(agent[i]);
            }

            agent.Dispose();
            Console.ReadKey();

        }
    }
}



