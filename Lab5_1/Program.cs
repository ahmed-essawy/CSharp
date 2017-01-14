using System;

namespace Lab5_1_Indexer
{
	class Program
	{
		class student
		{
			string name;
			int[] grade;
			int tot_len;
			int size;
			public student(int size = 1)
			{
				name = "Default Name";
				grade = new int[size];
				tot_len = size;
			}
			public string N
			{
				set { name = value; }
				get { return name; }
			}
			public int this[int i]
			{
				set
				{
					if (i >= 0 && i < tot_len)
					{
						grade[i] = value;
						++size;
					}
				}
				get
				{
					if (i >= 0 && i < size)
					{
						return grade[i];
					}
					else
					{
						return 0;
					}
				}
			}
			public int len
			{
				get { return size; }
			}
			public int lenght
			{
				get { return tot_len; }
			}
		}
		static void Main(string[] args)
		{
			student s1 = new student(5);
			Console.Write("Enter name: ");
			s1.N = Console.ReadLine();
			for (int i = 0; i < s1.lenght; i++)
			{
				Console.Write("Enter subj #" + (i + 1) + ": ");
				s1[i] = int.Parse(Console.ReadLine());
			}
			Console.Clear();
			student s2 = s1;
			Console.WriteLine("Name: " + s2.N);
			for (int i = 0; i < s2.len; i++)
			{
				Console.WriteLine("Subj #" + (i + 1) + ": " + s2[i]);
			}
			Console.ReadKey();
		}
	}
}