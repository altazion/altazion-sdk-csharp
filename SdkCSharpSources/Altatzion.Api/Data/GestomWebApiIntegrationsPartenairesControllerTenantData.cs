using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données TenantData
	///</summary>
	public class TenantData
	{
		///<summary>
		///Obtient ou définit la valeur TenantId
		///</summary>
		public int TenantId{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Name
		///</summary>
		public string Name{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Code
		///</summary>
		public string Code{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MainLicenceGuid
		///</summary>
		public Guid MainLicenceGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Stores
		///</summary>
		public TenantStoreData[] Stores{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CatalogDatas
		///</summary>
		public TenantCatalogData[] CatalogDatas{ get; set; }

		///<summary>
		///Obtient ou définit la valeur GlobalData
		///</summary>
		public TenantGlobalData GlobalData{ get; set; }

	}
}
