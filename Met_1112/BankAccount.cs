using System.Diagnostics;

namespace Met_1112
{
	class BankAccount
	{
		private int index;

		static int indexer = 0;		

		public BankAccount()
		{
			index = indexer++;
		}

		[Conditional("DEBUGGING")]
		public void DumpToScreen()
        {
			// а что делать собственно?
        }
	}
}
