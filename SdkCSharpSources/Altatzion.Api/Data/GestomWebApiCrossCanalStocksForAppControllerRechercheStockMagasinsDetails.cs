using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données RechercheStockMagasinsDetails
	///</summary>
	public class RechercheStockMagasinsDetails
	{
		///<summary>
		///Obtient ou définit la valeur ArticleReference
		///</summary>
		public string ArticleReference{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ArticleGuid
		///</summary>
		public Guid ArticleGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstDisponible
		///</summary>
		public bool EstDisponible{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Quantite
		///</summary>
		public decimal Quantite{ get; set; }

	}
}
