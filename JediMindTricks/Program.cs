using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JediMindTricks
{
	/// <summary>
	/// Class <c>Program</c> contains all the code for this application. Each assignment is split into methods,
	/// which are then executed by the Main. Add and remove commenting markers to execute each assignement.
	/// </summary>
	public class Program
	{
		public static void Main(string[] args)
		{
			Assignment1And2();
			//Assignment3();
			//Assignment4();
		}

		public static void Assignment1And2()  // Assignment 1 and 2, declaring and initializing dictionary, creating key and value entries.
		{
			Dictionary<string, int> people = new Dictionary<string, int>()  // Key is name, value is age of the character
			{
				{ "Luke", 19 }, { "Leila", 19}, { "Chewbacca", 194}, {"Han", 32}, {"Anakin", 41}
			};

			foreach (KeyValuePair<string, int> elmnt in people)
			{
				Console.WriteLine("Name: {0}\nAge: {1}\n\n", elmnt.Key, elmnt.Value);
			}
		}
		public static void Assignment3()  // Removing Han Solo.
		{
			Dictionary<string, int> people = new Dictionary<string, int>()  // Key is name, value is age of the character
			{
				{ "Luke", 19 }, { "Leila", 19}, { "Chewbacca", 194}, {"Han", 32}, {"Anakin", 41}
			};

			people.Remove("Han");

			foreach (KeyValuePair<string, int> elmnt in people)
			{
				Console.WriteLine("Name: {0}\nAge: {1}\n\n", elmnt.Key, elmnt.Value);
			}
		}
		public static void Assignment4()  // Using var.
		{
				Dictionary<string, int> people = new Dictionary<string, int>()  // Key is name, value is age of the character
			{
				{ "Luke", 19 }, { "Leila", 19}, { "Chewbacca", 194}, {"Han", 32}, {"Anakin", 41}
			};

			foreach (var person in people)
			{
				Console.WriteLine($"Name: {person.Key}\nAge: {person.Value}\n\n");
			}
		}
	}
}
