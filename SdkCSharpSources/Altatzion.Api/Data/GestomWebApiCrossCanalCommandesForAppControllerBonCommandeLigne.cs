using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données BonCommandeLigne
	///</summary>
	public class BonCommandeLigne
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ArticleGuid
		///</summary>
		public Guid ArticleGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Reference
		///</summary>
		public string Reference{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Quantite
		///</summary>
		public decimal Quantite{ get; set; }

		///<summary>
		///Obtient ou définit la valeur QuantiteExpediee
		///</summary>
		public decimal QuantiteExpediee{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuTtc
		///</summary>
		public decimal PuTtc{ get; set; }

	}
}
