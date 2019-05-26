using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Ventes
{
	public class DevisApiClient : ApiClientBase
	{
		public DevisApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void GetListeEnCours(bool avecLigne)
		{
		}
		public void GetObtenir(long devisId)
		{
		}
		public void GetObtenir(string devisNumero)
		{
		}
		public void PostValider(long devisId,DevisAcceptationInfo info)
		{
		}
		public void PostAjouter(InfosLigneDevis infos)
		{
		}
	}
}
