using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsMediator
{
	public class CEO
	{
		public CEO()
		{
			Mediator.Instance.ProductChanged += (s, e) => 
			{ 
				Console.WriteLine("This is the CEO speaking. Well done for selling {0}", e.Product.Name); 
			};
		}
	}
}
