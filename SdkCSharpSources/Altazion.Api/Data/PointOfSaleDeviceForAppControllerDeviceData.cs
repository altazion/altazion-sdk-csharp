using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données DeviceData
	///</summary>
	public class DeviceData
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Name
		///</summary>
		public string Name{ get; set; }

		///<summary>
		///Obtient ou définit la valeur StoreName
		///</summary>
		public string StoreName{ get; set; }

		///<summary>
		///Obtient ou définit la valeur StoreCode
		///</summary>
		public string StoreCode{ get; set; }

		///<summary>
		///Obtient ou définit la valeur StoreGuid
		///</summary>
		public Guid? StoreGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Kind
		///</summary>
		public PosteTypeEcran Kind{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DeviceCode
		///</summary>
		public string DeviceCode{ get; set; }

	}
}
