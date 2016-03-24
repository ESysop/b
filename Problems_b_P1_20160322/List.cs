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
		
			public void initiateList ()
				{
					wordList.Add(" ");
				}
		public void AskForWord ()
			{
				
				for (int wordListLegth = 0; wordListLegth < wordList.Count; wordListLegth++)
					{
					Console.WriteLine("Enter a word one time please....");
					string userInput = Console.ReadLine();

					if (wordList.Contains(userInput))
						{
						Console.WriteLine("Your Short Term Memory is Completely Shot, You have already used this word,\nThe program will now delete all your hard work.\n\n Have a day.");
						}
					else
						{
						wordList.Add(userInput);
						AskForWord();
						}
					}
				
			}
		}
	}
	