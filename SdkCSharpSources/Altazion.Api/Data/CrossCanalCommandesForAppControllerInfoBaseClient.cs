using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données InfoBaseClient
	///</summary>
	public class InfoBaseClient
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Nom
		///</summary>
		public string Nom{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Email
		///</summary>
		public string Email{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Telephone
		///</summary>
		public string Telephone{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Mobile
		///</summary>
		public string Mobile{ get; set; }

	}
}
