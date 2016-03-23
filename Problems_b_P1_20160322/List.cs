using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_b_P1_20160322
	{
	class List
		{
		List<string> wordList = new List<string>();

		public void UserInput ()
			{
			//while() //to continue input of words until dupe is found
			Console.WriteLine("Enter a word one time please....");
			string userInput = Console.ReadLine();
			wordList.Add(userInput);
			}
		//for loop to iterate list
		}
	}
