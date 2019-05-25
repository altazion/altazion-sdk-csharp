using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class InfosLigneDevis
	{
		public string dev_numero{ get; set; }
		public long art_pk{ get; set; }
		public string libelle{ get; set; }
		public decimal qte{ get; set; }
		public decimal? pu_ht{ get; set; }
		public decimal? pu_ttc{ get; set; }
		public string commentaire{ get; set; }
		public bool estOptionnel{ get; set; }
		public string idExterne{ get; set; }
	}
}
