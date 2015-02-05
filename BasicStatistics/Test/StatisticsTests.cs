using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BasicStatistics.Tests
{
	/// <summary>
	/// A test class for ...
	/// </summary>
	[TestFixture]
	public class StatisticsTests
	{
		#region Setup and Tear down
		/// <summary>
		/// This runs only once at the beginning of all tests and is used for all tests in the 
		/// class.
		/// </summary>
		[TestFixtureSetUp]
		public void InitialSetup()
		{

		}

		/// <summary>
		/// This runs only once at the end of all tests and is used for all tests in the class.
		/// </summary>
		[TestFixtureTearDown]
		public void FinalTearDown()
		{

		}

		/// <summary>
		/// This setup funcitons runs before each test method
		/// </summary>
		[SetUp]
		public void SetupForEachTest()
		{
		}

		/// <summary>
		/// This setup funcitons runs after each test method
		/// </summary>
		[TearDown]
		public void TearDownForEachTest()
		{
		}
		#endregion

		[Test]
		public void AddNumber_ShouldAddGivenNumberToNumbersList()
		{
			// Step 1 - Arrange
			Statistics myStatistics = new Statistics();

			// Step 2 - Act
			double num = 0;
			myStatistics.AddNumber(num);

			// Step 3 - Assert  
			Assert.IsTrue(myStatistics.numbers.Contains(num));
		}

		[Test]
		public void AddNumber_ShouldAddGivenNumberToSum()
		{
			Statistics myStatistics = new Statistics();

			double num = 1;
			myStatistics.AddNumber(num);

			Assert.AreEqual(1, myStatistics.Sum);
		}
	}
}
