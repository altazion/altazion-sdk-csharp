using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données TaxeData
	///</summary>
	public class TaxeData
	{
		///<summary>
		///Obtient ou définit la valeur Id
		///</summary>
		public Guid Id{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstFixe
		///</summary>
		public bool EstFixe{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Taux
		///</summary>
		public decimal Taux{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstInclue
		///</summary>
		public bool EstInclue{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CodeCompta
		///</summary>
		public string CodeCompta{ get; set; }

	}
}
