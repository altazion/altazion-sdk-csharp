using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Commercial
{

	///<summary>
	///Client api pour le domaine Commercial / Publicités
	///sur l'api Serveur
	///</summary>
	public partial class PublicitesApiClient : ApiClientBase
	{
		public PublicitesApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Créé une nouvelle opération commerciale de type publicité
		///</summary>
		public Guid PostCreer(NouvellePublicite publicite)
		{
			return base.Post<NouvellePublicite,Guid>($"app/commercial/opecom/publicite/new",publicite);
		}

		/// <summary>
		/// Valide une publicité, afin qu'elle puisse être affichée.
		///</summary>
		public bool GetActiver(Guid guid)
		{
			return base.Get<bool>($"app/commercial/opecom/publicite/{ base.ConvertDataToUrlFragment(guid, guid.GetType()) }/valider");
		}

		/// <summary>
		/// Désactive une publicité, la rendant non visible.
		///</summary>
		public bool GetDesactiver(Guid guid)
		{
			return base.Get<bool>($"app/commercial/opecom/publicite/{ base.ConvertDataToUrlFragment(guid, guid.GetType()) }/devalider");
		}

		/// <summary>
		/// Supprime une publicité.
		///</summary>
		public bool Supprimer(Guid guid)
		{
			return base.Delete<bool>($"app/commercial/opecom/publicite/{ base.ConvertDataToUrlFragment(guid, guid.GetType()) }");
		}

		/// <summary>
		/// Récupère les détails d'une opération publicitaire utilisant le module 'classique'
		///</summary>
		public PubliciteData GetDetailsPub(Guid opeGuid)
		{
			return base.Get<PubliciteData>($"app/commercial/opecom/publicite/{ base.ConvertDataToUrlFragment(opeGuid, opeGuid.GetType()) }/base");
		}

		/// <summary>
		/// Met à jour les détails d'une opération publicitaire utilisant le module de présentation 'classique'
		///</summary>
		public bool PostEditerPub(Publicite item)
		{
			return base.Post<Publicite,bool>($"app/commercial/opecom/publicite/base",item);
		}

		/// <summary>
		/// Récupère les détails d'une opération publicitaire utilisant le templating XML
		///</summary>
		public PubliciteXmlData GetDetailsPubXML(Guid opeGuid)
		{
			return base.Get<PubliciteXmlData>($"app/commercial/opecom/publicite/{ base.ConvertDataToUrlFragment(opeGuid, opeGuid.GetType()) }/xml");
		}

		/// <summary>
		/// Met à jour les détails d'une opération publicitaire utilisant le templating XML
		///</summary>
		public bool PostEditerPubXML(PubliciteXml item)
		{
			return base.Post<PubliciteXml,bool>($"app/commercial/opecom/publicite/xml",item);
		}

		/// <summary>
		/// Obtient une url pour uploader une image
		///</summary>
		public UploadUrl GetUploadurl(Guid opeGuid, string extension, int etape)
		{
			return base.Get<UploadUrl>($"app/commercial/opecom/helper/getuploadurl/{ base.ConvertDataToUrlFragment(opeGuid, opeGuid.GetType()) }/{ base.ConvertDataToUrlFragment(extension, extension.GetType()) }?etape={ base.ConvertDataToUrlFragment(etape, etape.GetType()) }");
		}

	}
}
