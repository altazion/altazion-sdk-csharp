﻿using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données TenantGlobalData
	///</summary>
	public class TenantGlobalData
	{
		///<summary>
		///Obtient ou définit la valeur UrlErp
		///</summary>
		public string UrlErp{ get; set; }

		///<summary>
		///Obtient ou définit la valeur UrlPosCentral
		///</summary>
		public string UrlPosCentral{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DeployedComponents
		///</summary>
		public String[] DeployedComponents{ get; set; }

	}
}
