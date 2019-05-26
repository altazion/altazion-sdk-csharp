using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données AvisClient
	///</summary>
	public class AvisClient
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ArticleGuid
		///</summary>
		public Guid ArticleGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Nom
		///</summary>
		public string Nom{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Message
		///</summary>
		public string Message{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ClientGuid
		///</summary>
		public Guid? ClientGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Email
		///</summary>
		public string Email{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstValide
		///</summary>
		public bool EstValide{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Date
		///</summary>
		public DateTime Date{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Note
		///</summary>
		public decimal Note{ get; set; }

	}
}
