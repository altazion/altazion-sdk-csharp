using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class ArticleMarketPlace
	{
		public string NomVendeur{ get; set; }
		public decimal Prix{ get; set; }
		public decimal? PrixPromotionnel{ get; set; }
		public DateTime? DateDebutPromotion{ get; set; }
		public DateTime? DateFinPromotion{ get; set; }
	}
}
