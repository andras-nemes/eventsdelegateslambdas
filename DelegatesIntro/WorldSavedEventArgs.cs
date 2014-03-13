using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesIntro
{
	public class WorldSavedEventArgs : EventArgs
	{
		public string SaviourName { get; set; }
		public DateTime DateOfNextCatastrophy { get; set; }
		public int WorkHasBeenOngoingHs { get; set; }
	}
}
