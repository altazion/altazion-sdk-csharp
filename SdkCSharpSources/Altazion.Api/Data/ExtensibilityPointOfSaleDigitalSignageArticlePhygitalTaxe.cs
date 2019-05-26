using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticlePhygitalTaxe
	///</summary>
	public class ArticlePhygitalTaxe
	{
		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Code
		///</summary>
		public string Code{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Montant
		///</summary>
		public decimal Montant{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstInclusDansPrix
		///</summary>
		public bool EstInclusDansPrix{ get; set; }

	}
}
