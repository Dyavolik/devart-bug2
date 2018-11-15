using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DevartBug
{
	internal static class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Start");

			try
			{
				using (var db = NewDbContext())
				{
					var data = db.Set<RecordOne>()
						.Select(x => x.RecordManyList.Any())
						.ToListAsync()
						.Result;
				}
			}
			catch (Exception e)
			{
				Console.Error.WriteLine(e);
			}

			Console.WriteLine("Finish!");
			Console.ReadKey();
		}

		private static MyDbContext NewDbContext()
		   => new MyDbContext($"Server=localhost; Port=3306; Database=test; Uid=root; Pwd=root; CharSet=utf8; License Key={LicenseKey};");

		private const string LicenseKey =
			"";
	}
}
