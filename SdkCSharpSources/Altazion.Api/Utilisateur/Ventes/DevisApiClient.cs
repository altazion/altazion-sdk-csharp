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
		public Devis GetObtenir(long devisId)
		{
			return base.Get<Devis>($"api/ventes/devis/{ base.ConvertDataToUrlFragment(devisId, devisId.GetType()) }");
		}

		/// <summary>
		/// Récupère une dernière révision de devis
		///</summary>
		public Devis GetObtenir(string devisNumero)
		{
			return base.Get<Devis>($"api/ventes/devis/revision/{ base.ConvertDataToUrlFragment(devisNumero, devisNumero.GetType()) }?devisNumero={ base.ConvertDataToUrlFragment(devisNumero, devisNumero.GetType()) }");
		}

		/// <summary>
		/// Valide un devis (enregistre son acceptation par le client
		///</summary>
		public Devis PostValider(long devisId, DevisAcceptationInfo info)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Ajoute une ligne à un devis
		///</summary>
		public bool PostAjouter(InfosLigneDevis infos)
		{
			throw new NotImplementedException();
		}

	}
}
