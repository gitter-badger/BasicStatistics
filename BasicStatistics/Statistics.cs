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
		List<double> numbers;
		public double Sum { get; set; }
		public double Min { get; set; }
		public double Max { get; set; }

		// Initialize numbers list.
		public Statistics()
		{
			numbers = new List<double>();
		}

		public int Count
		{
			get { return numbers.Count; }
		}

	}
}
