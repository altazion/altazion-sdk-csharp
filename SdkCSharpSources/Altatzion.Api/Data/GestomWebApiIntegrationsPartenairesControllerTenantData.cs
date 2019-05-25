using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class TenantData
	{
		public int TenantId{ get; set; }
		public string Name{ get; set; }
		public string Code{ get; set; }
		public Guid MainLicenceGuid{ get; set; }
		public TenantStoreData[] Stores{ get; set; }
		public TenantCatalogData[] CatalogDatas{ get; set; }
		public TenantGlobalData GlobalData{ get; set; }
	}
}
