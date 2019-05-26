using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données TenantCatalogData
	///</summary>
	public class TenantCatalogData
	{
		///<summary>
		///Obtient ou définit la valeur Kind
		///</summary>
		public CatalogKind Kind{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Name
		///</summary>
		public string Name{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Url
		///</summary>
		public string Url{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Id
		///</summary>
		public int Id{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Code
		///</summary>
		public string Code{ get; set; }

	}
}
