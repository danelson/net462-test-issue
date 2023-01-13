using Xunit;

namespace Net462TestIssue.XUnit
{
	public class Tests
	{
		[Fact]
		public void Test()
		{
			Net462.Program.Do();
		}
	}
}