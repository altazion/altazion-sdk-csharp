using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données Destination
	///</summary>
	public class Destination
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Type
		///</summary>
		public string Type{ get; set; }

		///<summary>
		///Obtient ou définit la valeur GroupeAnimationGuid
		///</summary>
		public Guid? GroupeAnimationGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur SiteId
		///</summary>
		public System.Int32? SiteId{ get; set; }

	}
}
