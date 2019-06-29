using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Parametres
{

	///<summary>
	///Client api pour le domaine Paramètres / Options
	///sur l'api Utilisateur
	///</summary>
	public partial class OptionsApiClient : ApiClientBase
	{
		public OptionsApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Obtient les options systèmes
		///</summary>
		public SysParamsOptions[] GetOptionsliste(string section, string group, string option)
		{
			return base.Get<SysParamsOptions[]>($"api/settings/system/options?section={ base.ConvertDataToUrlFragment(section, section.GetType()) }&group={ base.ConvertDataToUrlFragment(group, group.GetType()) }&option={ base.ConvertDataToUrlFragment(option, option.GetType()) }");
		}

		/// <summary>
		/// Definit une option système
		///</summary>
		public SysParamsOptions GetOptionsset(string section, string group, string option, string value)
		{
			return base.Get<SysParamsOptions>($"api/settings/system/options/set?section={ base.ConvertDataToUrlFragment(section, section.GetType()) }&group={ base.ConvertDataToUrlFragment(group, group.GetType()) }&option={ base.ConvertDataToUrlFragment(option, option.GetType()) }&value={ base.ConvertDataToUrlFragment(value, value.GetType()) }");
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
