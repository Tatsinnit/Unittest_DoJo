using System;

namespace UnitTestLibrary
{
	public class UnitTestStringLibrary : IUnitTestStringLibrary
	{
		public UnitTestStringLibrary ()
		{
		}

		public string combineArrayStringWithSpace(string[] stringArray)
		{
			string str = default(string);

			foreach (string item in stringArray)
			{
				str += item + " ";
			}

			return str.Trim();
		}
	}
}

