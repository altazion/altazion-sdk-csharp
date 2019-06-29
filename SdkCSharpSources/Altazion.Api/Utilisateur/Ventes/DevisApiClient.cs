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
	public class DevisApiClient : ApiClientBase
	{
		public DevisApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère la liste des devis 'en cours'
		///</summary>
		public Devis[] GetListeEnCours(bool avecLigne)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère une dernière révision de devis
		///</summary>
		public Devis GetObtenir(long devisId)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère une dernière révision de devis
		///</summary>
		public Devis GetObtenir(string devisNumero)
		{
			throw new NotImplementedException();
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
