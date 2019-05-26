using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticlePhygitalLogistiqueSpecificites
	///</summary>
	public class ArticlePhygitalLogistiqueSpecificites
	{
		///<summary>
		///Obtient ou définit la valeur TypePreparation
		///</summary>
		public string TypePreparation{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MatiereDangereuse
		///</summary>
		public bool MatiereDangereuse{ get; set; }

		///<summary>
		///Obtient ou définit la valeur RestrictionsExport
		///</summary>
		public bool RestrictionsExport{ get; set; }

	}
}
