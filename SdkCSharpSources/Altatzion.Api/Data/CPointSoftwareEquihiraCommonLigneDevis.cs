using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class LigneDevis
	{
		public decimal Id{ get; set; }
		public MetaTypeArticle TypeLigne{ get; set; }
		public decimal DevisId{ get; set; }
		public long ArticleId{ get; set; }
		public string ArticleLibelle{ get; set; }
		public string ArticleCommentaires{ get; set; }
		public decimal Quantite{ get; set; }
		public decimal PuHt{ get; set; }
		public decimal PuTtc{ get; set; }
	}
}
