using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class TaxeData
	{
		public Guid Id{ get; set; }
		public string Libelle{ get; set; }
		public bool EstFixe{ get; set; }
		public decimal Taux{ get; set; }
		public bool EstInclue{ get; set; }
		public string CodeCompta{ get; set; }
	}
}
