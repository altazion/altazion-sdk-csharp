using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Commercial
{
	public class PublicitesApiClient : ApiClientBase
	{
		public PublicitesApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void PostCreer(NouvellePublicite publicite)
		{
		}
		public void GetActiver(Guid guid)
		{
		}
		public void GetDesactiver(Guid guid)
		{
		}
		public void DeleteSupprimer(Guid guid)
		{
		}
		public void GetDetailsPub(Guid opeGuid)
		{
		}
		public void PostEditerPub(Publicite item)
		{
		}
		public void GetDetailsPubXML(Guid opeGuid)
		{
		}
		public void PostEditerPubXML(PubliciteXml item)
		{
		}
		public void GetUploadurl(Guid opeGuid,string extension,int etape)
		{
		}
	}
}
