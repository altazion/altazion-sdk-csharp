using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class RechercheStockMagasins
	{
		public string MagasinCode{ get; set; }
		public Guid MagasinGuid{ get; set; }
		public string MagasinLibelle{ get; set; }
		public string MagasinCP{ get; set; }
		public RechercheStockMagasinsDetails[] Produits{ get; set; }
	}
}
