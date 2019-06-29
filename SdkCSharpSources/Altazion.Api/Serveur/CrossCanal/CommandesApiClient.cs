using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.CrossCanal
{

	///<summary>
	///Client api pour le domaine Cross Canal / Commandes
	///sur l'api Serveur
	///</summary>
	public class CommandesApiClient : ApiClientBase
	{
		public CommandesApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Crée une nouvelle commande destinée à un magasin.
		///</summary>
		public Guid PutPasserUneCommande(int siteId, Guid magasinGuid, Commande commande)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère la liste des 50 dernières commandes 'magasin'
		///</summary>
		public CommandeEnAttente[] GetCommandesEnAttente(int siteId)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère la liste des 50 dernières commandes 'magasin'
		///</summary>
		public CommandeEnAttente[] GetCommandesEnAttente(int siteId, Guid magasinGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère le détail d'une commande
		///</summary>
		public BonCommandeDetails GetDetails(int siteId, string numero)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère le détail d'une commande
		///</summary>
		public BonCommandeDetails GetDetails(int siteId, Guid orderGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Marque une commande comme terminée
		///</summary>
		public BonCommandeDetails GetTerminer(int siteId, Guid orderGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Valide le règlement associé à une commande
		///</summary>
		public BonCommandeDetails PutPaiementsimple(int siteId, Guid bcdGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Déclare l'enlèvement d'une commande
		///</summary>
		public BonCommandeDetails PutDeclareEnlevement(int siteId, Guid bcdGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retourne les modes de règlements possibles.
		///</summary>
		public ModeReglement[] GetModesDeReglements(int siteId)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Connecte un client sur le site.
		///</summary>
		public InfoBaseClient PostConnexionClient(int siteId, LogClient log)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Connecte un client sur le site.
		///</summary>
		public InfoBaseClient PostConnexionClient(int siteId, LogClient log, Guid clientGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Connecte un client sur le site.
		///</summary>
		public MailCheckResult GetVerifEmail(int siteId, string email)
		{
			throw new NotImplementedException();
		}

	}
}
