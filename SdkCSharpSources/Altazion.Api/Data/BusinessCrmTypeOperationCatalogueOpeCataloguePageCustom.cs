using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données OpeCataloguePageCustom
	///</summary>
	public class OpeCataloguePageCustom
	{
		///<summary>
		///Obtient ou définit la valeur Items
		///</summary>
		public OpeCataloguePageItem[] Items{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CustomXmlData
		///</summary>
		public string CustomXmlData{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ImageUrl
		///</summary>
		public string ImageUrl{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CriteresUrl
		///</summary>
		public string CriteresUrl{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Title
		///</summary>
		public string Title{ get; set; }

	}
}
