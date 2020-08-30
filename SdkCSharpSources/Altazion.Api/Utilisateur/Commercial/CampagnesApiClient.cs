using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Commercial
{

	///<summary>
	///Client api pour le domaine Commercial / Campagnes
	///sur l'api Utilisateur
	///</summary>
	public partial class CampagnesApiClient : ApiClientBase
	{
		public CampagnesApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Récupère le liste des campagnes actives
		///</summary>
		public CampagnesData[] GetListeDesCampagnes()
		{
			return base.Get<CampagnesData[]>($"");
		}

		/// <summary>
		/// Permet de modifier/créer une campagne. La méthode PATCH permet uniquement de modifier une campagne.  La méthode POST met à jour une campagne si vous fournissez son Guid ou en crée une nouvelle si  vous laissez le Guid à Guid.Empty
		///</summary>
		public Guid PostModifierCampagne(CampagnesData data)
		{
			return base.Post<CampagnesData,Guid>($"",data);
		}

		/// <summary>
		/// Permet de modifier/créer une campagne. La méthode PATCH permet uniquement de modifier une campagne.  La méthode POST met à jour une campagne si vous fournissez son Guid ou en crée une nouvelle si  vous laissez le Guid à Guid.Empty
		///</summary>
		public Guid ModifierCampagne(CampagnesData data)
		{
			return base.Patch<CampagnesData,Guid>($"",data);
		}

		/// <summary>
		/// Archive une campagne
		///</summary>
		public bool ArchiverCampagne(Guid guid)
		{
			return base.Delete<bool>($"?guid={ base.ConvertDataToUrlFragment(guid, guid.GetType()) }");
		}

		/// <summary>
		/// Récupère la liste des types d'opérations possibles
		///</summary>
		public TypeOpeComm[] GetListeDesTypes(Guid? destination)
		{
			return base.Get<TypeOpeComm[]>($"api/commercial/typesope?destination={ base.ConvertDataToUrlFragment(destination, destination.GetType()) }");
		}

		/// <summary>
		/// Récupère la liste des destinations
		///</summary>
		public Destination[] GetListeDestinations()
		{
			return base.Get<Destination[]>($"api/commercial/destinations");
		}

		/// <summary>
		/// Récupère le planning des opérations commerciales
		///</summary>
		public OperationData[] GetPlanning(DateTime? min, DateTime? max, Guid? campagneGuid)
		{
			return base.Get<OperationData[]>($"api/commercial/planning?min={ base.ConvertDataToUrlFragment(min, min.GetType()) }&max={ base.ConvertDataToUrlFragment(max, max.GetType()) }&campagneGuid={ base.ConvertDataToUrlFragment(campagneGuid, campagneGuid.GetType()) }");
		}

	}
}
