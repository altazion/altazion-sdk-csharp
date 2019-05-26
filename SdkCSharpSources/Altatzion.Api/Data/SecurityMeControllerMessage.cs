using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données Message
	///</summary>
	public class Message
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Uxid
		///</summary>
		public Guid? Uxid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur GroupeGuid
		///</summary>
		public Guid? GroupeGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Sujet
		///</summary>
		public string Sujet{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Details
		///</summary>
		public string Details{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstTraite
		///</summary>
		public bool EstTraite{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstImportant
		///</summary>
		public bool EstImportant{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Url
		///</summary>
		public string Url{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Date
		///</summary>
		public DateTimeOffset Date{ get; set; }

	}
}
