using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données TenantStoreData
	///</summary>
	public class TenantStoreData
	{
		///<summary>
		///Obtient ou définit la valeur StoreGuid
		///</summary>
		public Guid StoreGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur StoreName
		///</summary>
		public string StoreName{ get; set; }

		///<summary>
		///Obtient ou définit la valeur StoreCode
		///</summary>
		public string StoreCode{ get; set; }

		///<summary>
		///Obtient ou définit la valeur InStoreData
		///</summary>
		public TenantInStoreData InStoreData{ get; set; }

	}
}
