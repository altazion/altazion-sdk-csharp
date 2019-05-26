using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ContenuData
	///</summary>
	public class ContenuData
	{
		///<summary>
		///Obtient ou définit la valeur GArticle
		///</summary>
		public Guid GArticle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur IDBillet
		///</summary>
		public string IDBillet{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Contenu
		///</summary>
		public string Contenu{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeContenu
		///</summary>
		public string TypeContenu{ get; set; }

	}
}
