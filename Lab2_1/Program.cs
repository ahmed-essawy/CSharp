using System;

namespace Lab2_1
{
	enum position { manager, admin, tech }
	enum typet { full, part }
	struct employee
	{
		public string name;
		public string address;
		public position pos;
		public typet time;
		public int sal;
	}
	class Program
	{
		static void Main(string[] args)
		{
			employee emp;
			Console.Write("Enter name: ");
			emp.name = Console.ReadLine();
			Console.Write("Enter address: ");
			emp.address = Console.ReadLine();
			Console.Write("Enter position {1/2/3}: ");
			switch (int.Parse(Console.ReadLine()))
			{
				case 1:
					emp.pos = position.manager;
					break;
				case 2:
					emp.pos = position.admin;
					break;
				case 3:
					emp.pos = position.tech;
					break;
				default:
					emp.pos = position.tech;
					break;
			}
			Console.Write("Enter time {1/2}: ");
			emp.time = int.Parse(Console.ReadLine()) == 2 ? typet.part : typet.full;
			Console.Write("Enter salary: ");
			emp.sal = int.Parse(Console.ReadLine());
			Console.WriteLine("Name: " + emp.name);
			Console.WriteLine("Address: " + emp.address);
			Console.WriteLine("Position: " + emp.pos);
			Console.WriteLine("Time: " + emp.time);
			Console.WriteLine("Salary: " + emp.sal);
			Console.WriteLine("Net Salary: " + emp.sal*0.9);
			Console.ReadLine();
		}
	}
}
