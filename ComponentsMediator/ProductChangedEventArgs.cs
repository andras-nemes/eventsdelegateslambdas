using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsMediator
{
	public class ProductChangedEventArgs : EventArgs
	{
		public Product Product { get; set; }
	}
}
