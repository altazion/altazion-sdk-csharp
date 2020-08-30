using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ProduitsDevis
	///</summary>
	public class ProduitsDevis
	{
		///<summary>
		///Obtient ou définit la valeur ArticleId
		///</summary>
		public long ArticleId{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Commentaires
		///</summary>
		public string Commentaires{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Qte
		///</summary>
		public decimal Qte{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuHt
		///</summary>
		public decimal PuHt{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuTTC
		///</summary>
		public decimal PuTTC{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstOptionnel
		///</summary>
		public bool EstOptionnel{ get; set; }

	}
}
