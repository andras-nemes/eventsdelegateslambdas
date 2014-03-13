using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesIntro
{
	public class EventAccessorExample
	{
		public delegate void WorldSavedHandler(string saviourName, DateTime dateForNextCatastrophy);
		
		private WorldSavedHandler WorldHasBeenSaved;
		public event WorldSavedHandler WorldSaved
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				WorldHasBeenSaved = (WorldSavedHandler)Delegate.Combine(WorldHasBeenSaved, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				WorldHasBeenSaved = (WorldSavedHandler)Delegate.Remove(WorldHasBeenSaved, value);
			}
		}
	}
}
