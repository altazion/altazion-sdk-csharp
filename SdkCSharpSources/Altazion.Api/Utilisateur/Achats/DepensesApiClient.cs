using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Achats
{

	///<summary>
	///Client api pour le domaine Achats / Dépenses
	///sur l'api Utilisateur
	///</summary>
	public partial class DepensesApiClient : ApiClientBase
	{
		public DepensesApiClient(ApiConnection connection) : base(connection)
		{
		}

	}
}
