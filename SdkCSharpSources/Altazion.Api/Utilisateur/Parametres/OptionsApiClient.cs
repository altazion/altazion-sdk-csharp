using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Parametres
{
	public class OptionsApiClient : ApiClientBase
	{
		public OptionsApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void GetOptionsliste(string section,string group,string option)
		{
		}
		public void GetOptionsset(string section,string group,string option,string value)
		{
		}
		public void DeleteOptionsunset(string section,string group,string option)
		{
		}
	}
}
