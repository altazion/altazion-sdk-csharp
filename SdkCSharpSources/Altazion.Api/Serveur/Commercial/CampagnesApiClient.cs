using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Commercial
{
	public class CampagnesApiClient : ApiClientBase
	{
		public CampagnesApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void GetListeDesCampagnes()
		{
		}
		public void PostModifierCampagne(CampagnesData data)
		{
		}
		public void PatchModifierCampagne(CampagnesData data)
		{
		}
		public void DeleteArchiverCampagne(Guid guid)
		{
		}
		public void GetListeDesTypes(Guid? destination)
		{
		}
		public void GetListeDestinations()
		{
		}
		public void GetObtenirPlanning(DateTime? min,DateTime? max,Guid? campagneGuid)
		{
		}
	}
}
