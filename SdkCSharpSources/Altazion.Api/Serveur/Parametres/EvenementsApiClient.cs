using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Parametres
{

	///<summary>
	///Client api pour le domaine Paramètres / Evenements
	///sur l'api Serveur
	///</summary>
	public partial class EvenementsApiClient : ApiClientBase
	{
		public EvenementsApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Récupère les évènements magasins
		///</summary>
		public EvenementMagasin[] Get(Guid magasinguid)
		{
			return base.Get<EvenementMagasin[]>($"app/magasins/{ base.ConvertDataToUrlFragment(magasinguid, magasinguid.GetType()) }/evenements");
		}

		/// <summary>
		/// Récupère les évènements Cross Canaux non archivés
		///</summary>
		public EvenementCrossCanal[] GetCrosscanaux(DateTime? date1, DateTime? date2)
		{
			return base.Get<EvenementCrossCanal[]>($"app/magasins/evenements/crosscanal?date1={ base.ConvertDataToUrlFragment(date1, date1.GetType()) }&date2={ base.ConvertDataToUrlFragment(date2, date2.GetType()) }");
		}

		/// <summary>
		/// Créé un évènement magasin
		///</summary>
		public bool Creer(Guid magasinguid, ObjetCreationEvenementMagasin obj)
		{
			return base.Put<ObjetCreationEvenementMagasin,bool>($"app/magasins/{ base.ConvertDataToUrlFragment(magasinguid, magasinguid.GetType()) }/evenements",obj);
		}

		/// <summary>
		/// Modifie un évènement magasin
		///</summary>
		public bool Modifier(Guid evmguid, ObjetCreationEvenementMagasin obj)
		{
			return base.Patch<ObjetCreationEvenementMagasin,bool>($"app/magasins/{ base.ConvertDataToUrlFragment(magasinguid, magasinguid.GetType()) }/evenements/{ base.ConvertDataToUrlFragment(evmguid, evmguid.GetType()) }",obj);
		}

		/// <summary>
		/// Archive un évènement magasin
		///</summary>
		public bool Archiver(Guid evmguid)
		{
			return base.Delete<bool>($"app/magasins/{ base.ConvertDataToUrlFragment(magasinguid, magasinguid.GetType()) }/evenements/{ base.ConvertDataToUrlFragment(evmguid, evmguid.GetType()) }");
		}

		/// <summary>
		/// Inscrit un magasin à un évènement Cross Canal
		///</summary>
		public bool PostInscrire(Guid evcguid, Guid magguid)
		{
			return base.Post<bool>($"app/magasins/{ base.ConvertDataToUrlFragment(magguid, magguid.GetType()) }/evenements/crosscanal/{ base.ConvertDataToUrlFragment(evcguid, evcguid.GetType()) }");
		}

	}
}
