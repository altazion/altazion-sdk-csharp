using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class InfoBaseClient
	{
		public Guid Guid{ get; set; }
		public string Nom{ get; set; }
		public string Email{ get; set; }
		public string Telephone{ get; set; }
		public string Mobile{ get; set; }
	}
}
