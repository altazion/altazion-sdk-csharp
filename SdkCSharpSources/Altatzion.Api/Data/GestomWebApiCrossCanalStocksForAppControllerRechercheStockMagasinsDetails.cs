using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class RechercheStockMagasinsDetails
	{
		public string ArticleReference{ get; set; }
		public Guid ArticleGuid{ get; set; }
		public bool EstDisponible{ get; set; }
		public decimal Quantite{ get; set; }
	}
}
