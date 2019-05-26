using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données NewTenantData
	///</summary>
	public class NewTenantData
	{
		///<summary>
		///Obtient ou définit la valeur TenantId
		///</summary>
		public int TenantId{ get; set; }

		///<summary>
		///Obtient ou définit la valeur IsCreationInProgress
		///</summary>
		public bool IsCreationInProgress{ get; set; }

	}
}
