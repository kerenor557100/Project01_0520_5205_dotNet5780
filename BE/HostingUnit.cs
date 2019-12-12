using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
	class HostingUnit
	{
		public int HostingUnitKey { get; set; }
		public Host Owner { get; set; }
		public String HostingUnitName { get; set; }
		public int[,] Diary = new int[12, 31];
		public ToString //לבדוק

	}
}
