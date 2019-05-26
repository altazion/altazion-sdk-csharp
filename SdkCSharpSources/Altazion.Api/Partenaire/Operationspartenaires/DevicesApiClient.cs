using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Partenaire.Operationspartenaires
{
	public class DevicesApiClient : ApiClientBase
	{
		public DevicesApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void GetListeDevices(int tenantId)
		{
		}
		public void GetListeDesTypes(int tenantId,string kind)
		{
		}
		public void PutCreer(int tenantId,DeviceCreationData data)
		{
		}
	}
}
