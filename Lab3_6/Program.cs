using System;

namespace Lab3_6
{
	class login
	{
		string user;
		string pass;
		public void SetU(string u) { user = u; }
		public void SetP(string p) { pass = p; }
		public string GetU() { return user; }
		public string GetP() { return pass; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			login log = new login();
			Console.Write("Enter username: ");
			log.SetU(Console.ReadLine());
			Console.Write("Enter password: ");
			log.SetP(Console.ReadLine());
			Console.WriteLine("Check");
			Console.Write("Enter username: ");
			string user=Console.ReadLine();
			Console.Write("Enter password: ");
			string pass = Console.ReadLine();
			if (user == log.GetU().ToLower() && pass == log.GetP())
				Console.WriteLine("Correct");
			else
				Console.WriteLine("Wrong !");
			Console.ReadLine();
		}
	}
}
