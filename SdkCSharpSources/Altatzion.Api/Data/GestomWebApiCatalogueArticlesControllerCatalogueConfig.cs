using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données CatalogueConfig
	///</summary>
	public class CatalogueConfig
	{
		///<summary>
		///Obtient ou définit la valeur SiteName
		///</summary>
		public string SiteName{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Attributes
		///</summary>
		public AttributeData[] Attributes{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Languages
		///</summary>
		public LanguageData[] Languages{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Tags
		///</summary>
		public TagDescriptionData[] Tags{ get; set; }

	}
}
