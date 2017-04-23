using System;
using System.Collections.Generic;

namespace CsharpAssessment
{
	class MainClass
	{
		public static int number;
		public static bool flag = false;
		public static List<int> mylist = new List<int>();

		public static void Main(string[] args)
		{

			//adding a number to list 
			do
			{
				Console.WriteLine("Would you like to add a number to the list? (y/n):");

				string response = Console.ReadLine().ToLower();

				if (response == "y")
				{
					Console.WriteLine("Please enter a number");

					number = int.Parse(Console.ReadLine());

					mylist.Add(number);

				}
				else
				{
					flag = true;
				}




			} while (!flag);

			//calculating a average and sorting a list item
			string input;
			do{
				Console.WriteLine("Type ‘A’ to get the average of the list, ‘S’ to sort it, or ‘X’ to exit:");

				input = Console.ReadLine().ToLower();

				switch (input)
				{

					case "a":
						float average;
						float sum = 0;
						foreach (int item in mylist)
						{

							sum += item;

						}
						average = sum / mylist.Count;
						Console.WriteLine("The Average is:" + average);

						break;

					case "s":
						mylist.Sort();
						Console.WriteLine("my sorted list items:");
						foreach (int item in mylist)
						{
							Console.WriteLine(item);
						}
						break;

					default:
						break;


				}

			}while (input != "x") ;


		}
	}
}
