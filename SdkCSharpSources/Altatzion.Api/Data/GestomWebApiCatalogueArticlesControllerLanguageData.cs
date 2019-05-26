using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données LanguageData
	///</summary>
	public class LanguageData
	{
		///<summary>
		///Obtient ou définit la valeur IsDefault
		///</summary>
		public bool IsDefault{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CultureCode
		///</summary>
		public string CultureCode{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Label
		///</summary>
		public string Label{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CatalogId
		///</summary>
		public int CatalogId{ get; set; }

	}
}
