using System;
using nb.Models.Foundation;

namespace nb.Models
{
	public class Need : IBaseModel
	{
		public int Id { get; set; }
		public DateTime CreateDate { get; set; }
		public string Name { get; set; }
		public Location Location { get; set; }
	}
}
