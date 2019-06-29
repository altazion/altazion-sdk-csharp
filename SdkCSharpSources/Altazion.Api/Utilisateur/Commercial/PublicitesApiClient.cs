using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Commercial
{

	///<summary>
	///Client api pour le domaine Commercial / Publicités
	///sur l'api Utilisateur
	///</summary>
	public class PublicitesApiClient : ApiClientBase
	{
		public PublicitesApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Créé une nouvelle opération commerciale de type publicité
		///</summary>
		public Guid PostCreer(NouvellePublicite publicite)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Valide une publicité, afin qu'elle puisse être affichée.
		///</summary>
		public bool GetActiver(Guid guid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Désactive une publicité, la rendant non visible.
		///</summary>
		public bool GetDesactiver(Guid guid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Supprime une publicité.
		///</summary>
		public bool DeleteSupprimer(Guid guid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère les détails d'une opération publicitaire utilisant le module 'classique'
		///</summary>
		public PubliciteData GetDetailsPub(Guid opeGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Met à jour les détails d'une opération publicitaire utilisant le module de présentation 'classique'
		///</summary>
		public bool PostEditerPub(Publicite item)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère les détails d'une opération publicitaire utilisant le templating XML
		///</summary>
		public PubliciteXmlData GetDetailsPubXML(Guid opeGuid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Met à jour les détails d'une opération publicitaire utilisant le templating XML
		///</summary>
		public bool PostEditerPubXML(PubliciteXml item)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Obtient une url pour uploader une image
		///</summary>
		public UploadUrl GetUploadurl(Guid opeGuid, string extension, int etape)
		{
			throw new NotImplementedException();
		}

	}
}
