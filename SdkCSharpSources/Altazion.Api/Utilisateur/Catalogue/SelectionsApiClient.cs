using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Catalogue
{

	///<summary>
	///Client api pour le domaine Catalogue / Selections
	///sur l'api Utilisateur
	///</summary>
	public class SelectionsApiClient : ApiClientBase
	{
		public SelectionsApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère la liste des sélections.
		///</summary>
		public VitrineData[] GetListeSelections()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère le détail d'une sélection.
		///</summary>
		public VitrineContentData GetDetailsSelection(Guid guid)
		{
			throw new NotImplementedException();
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
