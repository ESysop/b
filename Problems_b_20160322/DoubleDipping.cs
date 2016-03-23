using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_b_20160322
	{
	public class DoubleDipping
		{
		List<List<string>> wordsList = new List<List<string>>();
		
		public void CheckForDoubleDipping ()

			{
			List<string> test = new List<string>();
			test.Add("words");
			wordsList.Add(test);
			string wordIn;

			

			for (int i = 0; i < 3; i++)
				{
				Console.WriteLine("Enter your words below");
				wordIn = Console.ReadLine();
				wordsList.Add(wordIn);
								
				}

			}

		}
	}
