using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Catalogue
{

	///<summary>
	///Client api pour le domaine Catalogue / Segmentation
	///sur l'api Utilisateur
	///</summary>
	public class SegmentationApiClient : ApiClientBase
	{
		public SegmentationApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère la liste de toutes les segmentations
		///</summary>
		public SegmentationData[] GetListeSegmentations(string type)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère une segmentation et ses filles
		///</summary>
		public SegmentationDataDetails GetObtenirSegmentation(int segPk)
		{
			throw new NotImplementedException();
		}

	}
}
