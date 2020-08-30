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
	public partial class CommandesApiClient : ApiClientBase
	{
		public CommandesApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Crée une nouvelle commande destinée à un magasin.
		///</summary>
		public Guid PutPasserUneCommande(int siteId, Guid magasinGuid, Commande commande)
		{
			return base.Put<Commande,Guid>($"app/crosscanal/commandes/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/instore/{ base.ConvertDataToUrlFragment(magasinGuid, magasinGuid.GetType()) }",commande);
		}

		/// <summary>
		/// Récupère la liste des 50 dernières commandes 'magasin'
		///</summary>
		public CommandeEnAttente[] GetCommandesEnAttente(int siteId)
		{
			return base.Get<CommandeEnAttente[]>($"app/crosscanal/commandes/enattente/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/instore/local");
		}

		/// <summary>
		/// Récupère la liste des 50 dernières commandes 'magasin'
		///</summary>
		public CommandeEnAttente[] GetCommandesEnAttente(int siteId, Guid magasinGuid)
		{
			return base.Get<CommandeEnAttente[]>($"app/crosscanal/commandes/enattente/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/instore/{ base.ConvertDataToUrlFragment(magasinGuid, magasinGuid.GetType()) }");
		}

		/// <summary>
		/// Récupère le détail d'une commande
		///</summary>
		public BonCommandeDetails GetDetails(int siteId, string numero)
		{
			return base.Get<BonCommandeDetails>($"app/crosscanal/commandes/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/{ base.ConvertDataToUrlFragment(numero, numero.GetType()) }");
		}

		/// <summary>
		/// Récupère le détail d'une commande
		///</summary>
		public BonCommandeDetails GetDetails(int siteId, Guid orderGuid)
		{
			return base.Get<BonCommandeDetails>($"app/crosscanal/commandes/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/{ base.ConvertDataToUrlFragment(orderGuid, orderGuid.GetType()) }");
		}

		/// <summary>
		/// Marque une commande comme terminée
		///</summary>
		public BonCommandeDetails PostTerminer(int siteId, Guid orderGuid)
		{
			return base.Post<BonCommandeDetails>($"app/crosscanal/commandes/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/{ base.ConvertDataToUrlFragment(orderGuid, orderGuid.GetType()) }/terminer");
		}

		/// <summary>
		/// Valide le règlement associé à une commande
		///</summary>
		public BonCommandeDetails PutPaiementsimple(int siteId, Guid bcdGuid)
		{
			return base.Put<BonCommandeDetails>($"app/crosscanal/commandes/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/{ base.ConvertDataToUrlFragment(bcdGuid, bcdGuid.GetType()) }/paiement/confirmer");
		}

		/// <summary>
		/// Déclare l'enlèvement d'une commande
		///</summary>
		public BonCommandeDetails PutDeclareEnlevement(int siteId, Guid bcdGuid)
		{
			return base.Put<BonCommandeDetails>($"app/crosscanal/commandes/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/{ base.ConvertDataToUrlFragment(bcdGuid, bcdGuid.GetType()) }/paiement/confirmer");
		}

		/// <summary>
		/// Retourne les modes de règlements possibles.
		///</summary>
		public ModeReglement[] GetModesDeReglements(int siteId)
		{
			return base.Get<ModeReglement[]>($"app/crosscanal/commandes/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/modesreglements");
		}

		/// <summary>
		/// Connecte un client sur le site.
		///</summary>
		public InfoBaseClient PostConnexionClient(int siteId, LogClient log)
		{
			return base.Post<LogClient,InfoBaseClient>($"app/crosscanal/commandes/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/clients/connexion",log);
		}

		/// <summary>
		/// Connecte un client sur le site.
		///</summary>
		public InfoBaseClient PostConnexionClient(int siteId, LogClient log, Guid clientGuid)
		{
			return base.Post<LogClient,InfoBaseClient>($"app/crosscanal/commandes/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/clients/connexion/byguid/{ base.ConvertDataToUrlFragment(clientGuid, clientGuid.GetType()) }",log);
		}

		/// <summary>
		/// Connecte un client sur le site.
		///</summary>
		public MailCheckResult GetVerifEmail(int siteId, string email)
		{
			return base.Get<MailCheckResult>($"app/crosscanal/commandes/{ base.ConvertDataToUrlFragment(siteId, siteId.GetType()) }/clients/checkemail?email={ base.ConvertDataToUrlFragment(email, email.GetType()) }");
		}

	}
}
