using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Partenaire.Operationspartenaires
{

	///<summary>
	///Client api pour le domaine Opérations partenaires / Tenants
	///sur l'api Partenaire
	///</summary>
	public class TenantsApiClient : ApiClientBase
	{
		public TenantsApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère la liste des tenants associés à votre compte partenaire
		///</summary>
		public TenantData[] GetListe()
		{
			return base.Get<TenantData[]>($"api/partners/saas/tenants");
		}

		/// <summary>
		/// Crée un nouveau tenant associé à votre compte partenaire
		///</summary>
		public NewTenantData PutTenant(CreationRjsData data, bool synchrone)
		{
			throw new NotImplementedException();
		}

	}
}
