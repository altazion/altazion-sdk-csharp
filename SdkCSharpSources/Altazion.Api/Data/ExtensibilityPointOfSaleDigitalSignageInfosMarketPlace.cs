using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données InfosMarketPlace
	///</summary>
	public class InfosMarketPlace
	{
		///<summary>
		///Obtient ou définit la valeur VendeurPrincipal
		///</summary>
		public ArticleMarketPlace VendeurPrincipal{ get; set; }

		///<summary>
		///Obtient ou définit la valeur VendeursSecondaires
		///</summary>
		public ArticleMarketPlace[] VendeursSecondaires{ get; set; }

	}
}
