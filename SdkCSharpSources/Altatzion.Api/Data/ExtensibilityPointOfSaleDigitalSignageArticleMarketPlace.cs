using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticleMarketPlace
	///</summary>
	public class ArticleMarketPlace
	{
		///<summary>
		///Obtient ou définit la valeur NomVendeur
		///</summary>
		public string NomVendeur{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Prix
		///</summary>
		public decimal Prix{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PrixPromotionnel
		///</summary>
		public decimal? PrixPromotionnel{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateDebutPromotion
		///</summary>
		public DateTime? DateDebutPromotion{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateFinPromotion
		///</summary>
		public DateTime? DateFinPromotion{ get; set; }

	}
}
