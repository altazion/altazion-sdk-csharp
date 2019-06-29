using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Partenaire.Operationspartenaires
{

	///<summary>
	///Client api pour le domaine Opérations partenaires / Devices
	///sur l'api Partenaire
	///</summary>
	public class DevicesApiClient : ApiClientBase
	{
		public DevicesApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère la liste des devices pour un tenant
		///</summary>
		public DeviceData[] GetListeDevices(int tenantId)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère la liste des types de devices pour un tenant
		///</summary>
		public TypeDevice[] GetListeDesTypes(int tenantId, string kind)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Créer un nouveau device et en récupère les infos
		///</summary>
		public DeviceData PutCreer(int tenantId, DeviceCreationData data)
		{
			throw new NotImplementedException();
		}

	}
}
