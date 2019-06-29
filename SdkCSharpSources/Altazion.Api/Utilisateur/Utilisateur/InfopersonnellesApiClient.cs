﻿using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Utilisateur
{

	///<summary>
	///Client api pour le domaine Utilisateur / Info. personnelles
	///sur l'api Utilisateur
	///</summary>
	public class InfopersonnellesApiClient : ApiClientBase
	{
		public InfopersonnellesApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Obtient les messages envoyés à l'utilisateur
		///</summary>
		public Message[] GetMessages(bool inclureTraite, bool uniquementDirect, Guid? type)
		{
			throw new NotImplementedException();
		}

	}
}
