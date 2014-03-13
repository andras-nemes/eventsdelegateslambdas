using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsMediator
{
    public class Mediator
    {
		private static readonly Mediator _instance = new Mediator();

		private Mediator() { }

		public static Mediator Instance
		{
			get
			{
				return _instance;
			}
		}

		public event EventHandler<ProductChangedEventArgs> ProductChanged;

		public void OnProductChanged(object sender, Product product)
		{
			if (ProductChanged != null)
			{
				ProductChanged(sender, new ProductChangedEventArgs() { Product = product });
			}
		}
    }
}
