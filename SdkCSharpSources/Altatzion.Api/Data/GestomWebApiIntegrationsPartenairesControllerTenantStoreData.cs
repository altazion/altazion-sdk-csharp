using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class TenantStoreData
	{
		public Guid StoreGuid{ get; set; }
		public string StoreName{ get; set; }
		public string StoreCode{ get; set; }
		public TenantInStoreData InStoreData{ get; set; }
	}
}
