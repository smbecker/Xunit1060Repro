using System;
using Xunit;

namespace Xunit1060Repro
{
	public class Tests
	{
		[Fact]
		public void should_load_latest_version_of_newtonsoft() {
			var assembly = typeof(Newtonsoft.Json.Linq.JObject).Assembly.Location;
			Console.WriteLine(assembly);
			Assert.DoesNotContain("dotnet-xunit", assembly);
		}
		
		[Fact]
		public void can_load_native_dependencies() {
			using (var cn = new Microsoft.Data.Sqlite.SqliteConnection("Data Source=:memory:")) {
				cn.Open();
			}
		}
	}
}