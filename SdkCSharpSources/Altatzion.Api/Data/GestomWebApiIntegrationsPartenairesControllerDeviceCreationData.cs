using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données DeviceCreationData
	///</summary>
	public class DeviceCreationData
	{
		///<summary>
		///Obtient ou définit la valeur DeviceName
		///</summary>
		public string DeviceName{ get; set; }

		///<summary>
		///Obtient ou définit la valeur StoreGuid
		///</summary>
		public Guid StoreGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DeviceTypeGuid
		///</summary>
		public Guid DeviceTypeGuid{ get; set; }

	}
}
