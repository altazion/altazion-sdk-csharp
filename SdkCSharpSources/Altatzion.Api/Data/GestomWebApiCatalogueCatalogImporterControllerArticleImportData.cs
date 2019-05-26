using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticleImportData
	///</summary>
	public class ArticleImportData
	{
		///<summary>
		///Obtient ou définit la valeur ExternalId
		///</summary>
		public string ExternalId{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Reference
		///</summary>
		public string Reference{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Marque
		///</summary>
		public string Marque{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Description
		///</summary>
		public string Description{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Images
		///</summary>
		public ArticleImportImageData[] Images{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Proprietes
		///</summary>
		public Dictionary<System.String,System.String> Proprietes{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Dimensions
		///</summary>
		public ArticleImportDimensionsData Dimensions{ get; set; }

	}
}
