using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsMediator
{
	public class ProductChangeInitiator
	{
		public ProductChangeInitiator(int selectedProductId)
		{
			SelectedProductId = selectedProductId;			
		}

		public int SelectedProductId { get; set; }

	}
}
