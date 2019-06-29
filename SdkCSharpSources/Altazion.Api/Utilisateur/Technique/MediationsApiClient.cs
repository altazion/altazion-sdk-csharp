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
	public partial class MediationsApiClient : ApiClientBase
	{
		public MediationsApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Récupère la liste des définitions de médiations existantes.
		///</summary>
		public MediationDefinition[] GetDefinitions()
		{
			return base.Get<MediationDefinition[]>($"api/mediations/definitions");
		}

		/// <summary>
		/// Récupère l'état d'une médiation
		///</summary>
		public MediationStatus GetEtatDUneMediation(Guid mediationGuid)
		{
			return base.Get<MediationStatus>($"api/mediations/{ base.ConvertDataToUrlFragment(mediationGuid, mediationGuid.GetType()) }/status");
		}

		/// <summary>
		/// Récupère la liste des instances de médiations entre deux dates
		///</summary>
		public MediationStatus[] GetListeDesMediations(DateTime? minDate, DateTime? maxDate, Guid? definitionGuid)
		{
			return base.Get<MediationStatus[]>($"api/mediations/status?minDate={ base.ConvertDataToUrlFragment(minDate, minDate.GetType()) }&maxDate={ base.ConvertDataToUrlFragment(maxDate, maxDate.GetType()) }&definitionGuid={ base.ConvertDataToUrlFragment(definitionGuid, definitionGuid.GetType()) }");
		}

		/// <summary>
		/// Désactive une définition.
		///</summary>
		public bool GetDesactiverDefinition(Guid mediationDefinitionGuid)
		{
			return base.Get<bool>($"api/mediations/definitions/{ base.ConvertDataToUrlFragment(mediationDefinitionGuid, mediationDefinitionGuid.GetType()) }/disable");
		}

		/// <summary>
		/// Active une définition.
		///</summary>
		public bool GetActiverDefinition(Guid mediationDefinitionGuid)
		{
			return base.Get<bool>($"api/mediations/definitions/{ base.ConvertDataToUrlFragment(mediationDefinitionGuid, mediationDefinitionGuid.GetType()) }/enable");
		}

		/// <summary>
		/// Relance une médiation.
		///</summary>
		public MediationStatus GetRelancer(Guid mediationGuid)
		{
			return base.Get<MediationStatus>($"api/mediations/{ base.ConvertDataToUrlFragment(mediationGuid, mediationGuid.GetType()) }/restart");
		}

		/// <summary>
		/// Ignore la médiation et efface son éventuel message d'erreur.
		///</summary>
		public bool GetIgnorer(Guid mediationGuid)
		{
			return base.Get<bool>($"api/mediations/{ base.ConvertDataToUrlFragment(mediationGuid, mediationGuid.GetType()) }/ignore");
		}

	}
}
