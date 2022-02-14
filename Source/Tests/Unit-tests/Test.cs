using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class Test
	{
		#region Methods

		[TestMethod]
		public async Task FailingTest()
		{
			await Task.CompletedTask;

			Assert.AreEqual(1, 2);
		}

		[TestMethod]
		public async Task SucceedingTest()
		{
			await Task.CompletedTask;

			Assert.AreEqual(1, 1);
		}

		#endregion
	}
}