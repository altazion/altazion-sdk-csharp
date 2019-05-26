using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.CrossCanal
{
	public class CommandesApiClient : ApiClientBase
	{
		public CommandesApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void PutPasserUneCommande(int siteId,Guid magasinGuid,Commande commande)
		{
		}
		public void GetCommandesEnAttente(int siteId)
		{
		}
		public void GetCommandesEnAttente(int siteId,Guid magasinGuid)
		{
		}
		public void GetDetails(int siteId,string numero)
		{
		}
		public void GetDetails(int siteId,Guid orderGuid)
		{
		}
		public void GetTerminer(int siteId,Guid orderGuid)
		{
		}
		public void PutPaiementsimple(int siteId,Guid bcdGuid)
		{
		}
		public void PutDeclareEnlevement(int siteId,Guid bcdGuid)
		{
		}
		public void GetModesDeReglements(int siteId)
		{
		}
		public void PostConnexionClient(int siteId,LogClient log)
		{
		}
		public void PostConnexionClient(int siteId,LogClient log,Guid clientGuid)
		{
		}
		public void GetVerifEmail(int siteId,string email)
		{
		}
	}
}
