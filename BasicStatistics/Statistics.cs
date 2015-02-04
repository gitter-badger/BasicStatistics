using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStatistics
{
	public class Statistics
	{
		// Declare properties.
		public List<double> numbers;
		public double Sum { get; set; }
		public double Min { get; set; }
		public double Max { get; set; }

		// Initialize numbers list.
		public Statistics()
		{
			numbers = new List<double>();
		}

		/// <summary>
		/// Returns the count of items in the numbers list.
		/// </summary>
		public int Count
		{
			get { return numbers.Count; }
		}

		/// <summary>
		/// Add a number to the numbers list and Add that number to the total sum.
		/// </summary>
		/// <param name="number">The number to be added to the list.</param>
		public void AddNumber(double number)
		{
			numbers.Add(number);

			Sum += number;
		}

		/// <summary>
		/// Returns the average in the list of numbers.
		/// </summary>
		public double Average
		{
			get { return Sum / Count; }
		}
	}
}
