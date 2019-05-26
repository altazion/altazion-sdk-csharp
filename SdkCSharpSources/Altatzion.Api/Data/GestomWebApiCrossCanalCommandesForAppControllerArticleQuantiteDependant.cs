using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticleQuantiteDependant
	///</summary>
	public class ArticleQuantiteDependant
	{
		///<summary>
		///Obtient ou définit la valeur ArticleGuid
		///</summary>
		public Guid ArticleGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Quantite
		///</summary>
		public decimal Quantite{ get; set; }

	}
}
