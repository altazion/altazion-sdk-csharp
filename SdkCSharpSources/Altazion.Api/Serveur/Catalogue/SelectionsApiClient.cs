using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Catalogue
{

	///<summary>
	///Client api pour le domaine Catalogue / Selections
	///sur l'api Serveur
	///</summary>
	public partial class SelectionsApiClient : ApiClientBase
	{
		public SelectionsApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Récupère la liste des sélections.
		///</summary>
		public VitrineData[] GetListeSelections()
		{
			return base.Get<VitrineData[]>($"app/catalogue/selections");
		}

		/// <summary>
		/// Récupère le détail d'une sélection.
		///</summary>
		public VitrineContentData GetDetailsSelection(Guid guid)
		{
			return base.Get<VitrineContentData>($"app/catalogue/selections/{ base.ConvertDataToUrlFragment(guid, guid.GetType()) }/content");
		}

		/// <summary>
		/// Modifier une selection.
		///</summary>
		public VitrineContentData PostModifsimple(VitrineEditData data)
		{
			throw new NotImplementedException();
		}

	}
}
