using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticleDispoDigiSign
	///</summary>
	public class ArticleDispoDigiSign
	{
		///<summary>
		///Obtient ou définit la valeur MagasinGuid
		///</summary>
		public Guid? MagasinGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstDisponible
		///</summary>
		public bool EstDisponible{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Commentaire
		///</summary>
		public string Commentaire{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Stock
		///</summary>
		public decimal? Stock{ get; set; }

	}
}
