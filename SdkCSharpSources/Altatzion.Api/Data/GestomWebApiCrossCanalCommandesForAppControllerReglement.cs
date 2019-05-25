using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class Reglement
	{
		public decimal Montant{ get; set; }
		public Guid ModeReglementGuid{ get; set; }
		public string NumeroTransaction{ get; set; }
		public string CodeEtat{ get; set; }
	}
}
