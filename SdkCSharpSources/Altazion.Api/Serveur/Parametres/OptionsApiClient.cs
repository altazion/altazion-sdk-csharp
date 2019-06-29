using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Parametres
{

	///<summary>
	///Client api pour le domaine Paramètres / Options
	///sur l'api Serveur
	///</summary>
	public class OptionsApiClient : ApiClientBase
	{
		public OptionsApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Obtient les options systèmes
		///</summary>
		public SysParamsOptions[] GetOptionsliste(string section, string group, string option)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Definit une option système
		///</summary>
		public SysParamsOptions GetOptionsset(string section, string group, string option, string value)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Efface une option système
		///</summary>
		public SysParamsOptions DeleteOptionsunset(string section, string group, string option)
		{
			throw new NotImplementedException();
		}

	}
}
