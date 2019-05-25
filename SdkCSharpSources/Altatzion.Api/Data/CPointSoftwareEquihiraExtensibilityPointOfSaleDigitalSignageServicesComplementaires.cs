using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class ServicesComplementaires
	{
		public bool SelectionneParDefaut{ get; set; }
		public string Libelle{ get; set; }
		public string Code{ get; set; }
		public decimal PuHT{ get; set; }
		public decimal PuTTC{ get; set; }
	}
}
