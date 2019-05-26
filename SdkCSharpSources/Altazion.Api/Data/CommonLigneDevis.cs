using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données LigneDevis
	///</summary>
	public class LigneDevis
	{
		///<summary>
		///Obtient ou définit la valeur Id
		///</summary>
		public decimal Id{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeLigne
		///</summary>
		public MetaTypeArticle TypeLigne{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DevisId
		///</summary>
		public decimal DevisId{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ArticleId
		///</summary>
		public long ArticleId{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ArticleLibelle
		///</summary>
		public string ArticleLibelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ArticleCommentaires
		///</summary>
		public string ArticleCommentaires{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Quantite
		///</summary>
		public decimal Quantite{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuHt
		///</summary>
		public decimal PuHt{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuTtc
		///</summary>
		public decimal PuTtc{ get; set; }

	}
}
