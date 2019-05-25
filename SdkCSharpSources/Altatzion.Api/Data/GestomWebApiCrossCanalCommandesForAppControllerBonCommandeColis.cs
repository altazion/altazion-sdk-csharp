using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class BonCommandeColis
	{
		public Guid Guid{ get; set; }
		public string Transporteur{ get; set; }
		public DateTime DateEnvoi{ get; set; }
		public bool EstLivre{ get; set; }
	}
}
