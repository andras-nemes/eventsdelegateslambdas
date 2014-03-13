using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDelegates
{
	public class AsynchronousProcessSimulation
	{
		private delegate void ShowProgressDelegate(int status);

		public void StartReporting()
		{
			ShowProgressDelegate progressDelegate = new ShowProgressDelegate(DoProgress);
			
			progressDelegate.BeginInvoke(500, null, null);
			Console.WriteLine("Finishing the StartReporting method.");
		}

		private void DoProgress(int maxValue)
		{
			for (int i = 0; i <= maxValue; i++)
			{
				Console.WriteLine("Time : {0}", i);
				Thread.Sleep(50);
			}
		}
	}
}
