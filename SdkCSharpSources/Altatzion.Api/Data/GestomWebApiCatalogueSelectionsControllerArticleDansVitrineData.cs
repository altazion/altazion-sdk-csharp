using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticleDansVitrineData
	///</summary>
	public class ArticleDansVitrineData
	{
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
