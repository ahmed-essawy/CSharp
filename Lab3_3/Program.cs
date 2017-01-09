using System;

namespace Lab2_1
{
	enum position { manager, admin, tech }
	enum typet { full, part }
	class employee
	{
		string name;
		string address;
		position pos;
		typet time;
		int sal;
		public void Setn(string n) { name = n; }
		public void Seta(string a) { address = a; }
		public void Setp(int p)
		{
			switch (p)
			{
				case 1:
					pos = position.manager;
					break;
				case 2:
					pos = position.admin;
					break;
				case 3:
					pos = position.tech;
					break;
				default:
					pos = position.tech;
					break;
			}
		}
		public void Sett(int t) { time = t == 2 ? typet.part : typet.full; }
		public void Sets(int s) { sal = s; }
		public string GetN() { return name; }
		public string GetA() { return address; }
		public position GetP() { return pos; }
		public typet GetT() { return time; }
		public int GetS() { return sal; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			employee emp = new employee();
			Console.Write("Enter name: ");
			emp.Setn(Console.ReadLine());
			Console.Write("Enter address: ");
			emp.Seta(Console.ReadLine());
			Console.Write("Enter position {1/2/3}: ");
			emp.Setp(int.Parse(Console.ReadLine()));
			Console.Write("Enter time {1/2}: ");
			emp.Sett(int.Parse(Console.ReadLine()));
			Console.Write("Enter salary: ");
			emp.Sets(int.Parse(Console.ReadLine()));
			Console.WriteLine("Name: " + emp.GetN());
			Console.WriteLine("Address: " + emp.GetA());
			Console.WriteLine("Position: " + emp.GetP().ToString());
			Console.WriteLine("Time: " + emp.GetT().ToString());
			Console.WriteLine("Salary: " + emp.GetS());
			Console.WriteLine("Net Salary: " + emp.GetS() * 0.9);
			Console.ReadLine();
		}
	}
}
