using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticleReference
	///</summary>
	public class ArticleReference
	{
		///<summary>
		///Obtient ou définit la valeur Reference
		///</summary>
		public string Reference{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Type
		///</summary>
		public string Type{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstPrincipale
		///</summary>
		public bool EstPrincipale{ get; set; }

	}
}
