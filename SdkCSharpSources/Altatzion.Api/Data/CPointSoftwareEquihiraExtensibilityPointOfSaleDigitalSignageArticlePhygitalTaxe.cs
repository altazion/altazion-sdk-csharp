using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class ArticlePhygitalTaxe
	{
		public string Libelle{ get; set; }
		public string Code{ get; set; }
		public decimal Montant{ get; set; }
		public bool EstInclusDansPrix{ get; set; }
	}
}
