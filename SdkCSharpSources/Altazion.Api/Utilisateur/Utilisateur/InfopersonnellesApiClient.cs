using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Utilisateur
{
	public class InfopersonnellesApiClient : ApiClientBase
	{
		public InfopersonnellesApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void GetMessages(bool inclureTraite,bool uniquementDirect,Guid? type)
		{
		}
	}
}
