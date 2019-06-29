using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Technique
{

	///<summary>
	///Client api pour le domaine Technique / Médiations
	///sur l'api Utilisateur
	///</summary>
	public class MediationsApiClient : ApiClientBase
	{
		public MediationsApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère la liste des définitions de médiations existantes.
		///</summary>
		public MediationDefinition[] GetDefinitions()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère l'état d'une médiation
		///</summary>
		public MediationStatus GetEtatDUneMediation(Guid mediationGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère la liste des instances de médiations entre deux dates
		///</summary>
		public MediationStatus[] GetListeDesMediations(DateTime? minDate, DateTime? maxDate, Guid? definitionGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Désactive une définition.
		///</summary>
		public bool GetDesactiverDefinition(Guid mediationDefinitionGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Active une définition.
		///</summary>
		public bool GetActiverDefinition(Guid mediationDefinitionGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Relance une médiation.
		///</summary>
		public MediationStatus GetRelancer(Guid mediationGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Ignore la médiation et efface son éventuel message d'erreur.
		///</summary>
		public bool GetIgnorer(Guid mediationGuid)
		{
			throw new NotImplementedException();
		}

	}
}
