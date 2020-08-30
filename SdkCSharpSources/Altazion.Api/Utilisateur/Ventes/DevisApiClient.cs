using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Ventes
{

	///<summary>
	///Client api pour le domaine Ventes / Devis
	///sur l'api Utilisateur
	///</summary>
	public partial class DevisApiClient : ApiClientBase
	{
		public DevisApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Récupère la liste des devis 'en cours'
		///</summary>
		public Devis[] GetListeEnCours(bool avecLigne)
		{
			return base.Get<Devis[]>($"api/ventes/devis/encours?avecLigne={ base.ConvertDataToUrlFragment(avecLigne, avecLigne.GetType()) }");
		}

		/// <summary>
		/// Récupère une dernière révision de devis
		///</summary>
		public Devis Get(long devisId)
		{
			return base.Get<Devis>($"api/ventes/devis/{ base.ConvertDataToUrlFragment(devisId, devisId.GetType()) }");
		}

		/// <summary>
		/// Récupère une dernière révision de devis
		///</summary>
		public Devis Get(string devisNumero)
		{
			return base.Get<Devis>($"api/ventes/devis/revision/{ base.ConvertDataToUrlFragment(devisNumero, devisNumero.GetType()) }");
		}

		/// <summary>
		/// Valide un devis (enregistre son acceptation par le client
		///</summary>
		public Devis PostValider(long devisId, DevisAcceptationInfo info)
		{
			return base.Post<DevisAcceptationInfo,Devis>($"api/ventes/devis/{ base.ConvertDataToUrlFragment(devisId, devisId.GetType()) }/accepter",info);
		}

		/// <summary>
		/// Archiver un devis
		///</summary>
		public Devis PostArchiver(long devisId, DevisAcceptationInfo info)
		{
			return base.Post<DevisAcceptationInfo,Devis>($"api/ventes/devis/{ base.ConvertDataToUrlFragment(devisId, devisId.GetType()) }/archiver",info);
		}

		/// <summary>
		/// Facturer un devis
		///</summary>
		public Devis PostFacturer(long devisId, DevisFacture devis)
		{
			return base.Post<DevisFacture,Devis>($"api/ventes/devis/{ base.ConvertDataToUrlFragment(devisId, devisId.GetType()) }/facturer",devis);
		}

		/// <summary>
		/// Réviser un devis
		///</summary>
		public Devis PostReviser(long devisId, DevisAcceptationInfo info)
		{
			return base.Post<DevisAcceptationInfo,Devis>($"api/ventes/devis/{ base.ConvertDataToUrlFragment(devisId, devisId.GetType()) }/reviser",info);
		}

		/// <summary>
		/// Créer un devis
		///</summary>
		public Devis Creer(DevisInsert devis)
		{
			return base.Put<DevisInsert,Devis>($"api/ventes/devis/creer",devis);
		}

		/// <summary>
		/// Modifier un devis
		///</summary>
		public Devis Modifier(DevisInsert devis, long devisId)
		{
			return base.Patch<DevisInsert,Devis>($"api/ventes/devis/{ base.ConvertDataToUrlFragment(devisId, devisId.GetType()) }/modifier",devis);
		}

		/// <summary>
		/// Ajoute une ligne à un devis
		///</summary>
		public bool PostAjouter(InfosLigneDevis infos)
		{
			return base.Post<InfosLigneDevis,bool>($"api/ventes/devis/lignedevis",infos);
		}

	}
}
