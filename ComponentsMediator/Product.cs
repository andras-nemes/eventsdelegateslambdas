using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsMediator
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Registered { get; set; }
		public int OnStock { get; set; }
	}
}
