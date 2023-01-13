using System;
using System.Diagnostics.Metrics;

namespace Net462TestIssue.Net462
{
	public class Program
	{
		private static readonly Meter _meter = new Meter("Net462TestIssue");
		private static readonly Histogram<long> _histogram = _meter.CreateHistogram<long>("operation.duration", description: "The duration of an operation execution in milliseconds");

		public static void Main(string[] args)
		{
			Do();
			Console.WriteLine("success");
		}

		public static void Do()
		{
			_histogram.Record(123);
		}
	}
}
