using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticleDetailDansVitrineData
	///</summary>
	public class ArticleDetailDansVitrineData
	{
		///<summary>
		///Obtient ou définit la valeur ArticleLibelle
		///</summary>
		public string ArticleLibelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ArticleGuid
		///</summary>
		public Guid ArticleGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Pertinence
		///</summary>
		public decimal Pertinence{ get; set; }

	}
}
