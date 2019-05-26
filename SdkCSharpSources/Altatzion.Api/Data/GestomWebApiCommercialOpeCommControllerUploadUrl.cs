using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données UploadUrl
	///</summary>
	public class UploadUrl
	{
		///<summary>
		///Obtient ou définit la valeur Upload
		///</summary>
		public string Upload{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Result
		///</summary>
		public string Result{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Method
		///</summary>
		public string Method{ get; set; }

		///<summary>
		///Obtient ou définit la valeur HeadersToAdd
		///</summary>
		public Dictionary<System.String,System.String> HeadersToAdd{ get; set; }

	}
}
