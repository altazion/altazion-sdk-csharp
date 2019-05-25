using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class DeviceCreationData
	{
		public string DeviceName{ get; set; }
		public Guid StoreGuid{ get; set; }
		public Guid DeviceTypeGuid{ get; set; }
	}
}
