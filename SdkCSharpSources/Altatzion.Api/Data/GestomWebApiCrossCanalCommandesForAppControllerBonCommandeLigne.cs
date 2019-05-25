using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class BonCommandeLigne
	{
		public Guid Guid{ get; set; }
		public Guid ArticleGuid{ get; set; }
		public string Reference{ get; set; }
		public string Libelle{ get; set; }
		public decimal Quantite{ get; set; }
		public decimal QuantiteExpediee{ get; set; }
		public decimal PuTtc{ get; set; }
	}
}
