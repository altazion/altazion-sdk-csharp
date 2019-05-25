using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class DeviceData
	{
		public Guid Guid{ get; set; }
		public string Name{ get; set; }
		public string StoreName{ get; set; }
		public string StoreCode{ get; set; }
		public Guid? StoreGuid{ get; set; }
		public PosteTypeEcran Kind{ get; set; }
	}
}
