using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Technique
{
	public class MediationsApiClient : ApiClientBase
	{
		public MediationsApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void GetDefinitions()
		{
		}
		public void GetEtatDUneMediation(Guid mediationGuid)
		{
		}
		public void GetListeDesMediations(DateTime? minDate,DateTime? maxDate,Guid? definitionGuid)
		{
		}
		public void GetDesactiverDefinition(Guid mediationDefinitionGuid)
		{
		}
		public void GetActiverDefinition(Guid mediationDefinitionGuid)
		{
		}
		public void GetRelancer(Guid mediationGuid)
		{
		}
		public void GetIgnorer(Guid mediationGuid)
		{
		}
	}
}
