using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données MediationMessage
	///</summary>
	public class MediationMessage
	{
		///<summary>
		///Obtient ou définit la valeur Date
		///</summary>
		public DateTimeOffset Date{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Message
		///</summary>
		public string Message{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Kind
		///</summary>
		public MediationMessageKind Kind{ get; set; }

	}
}
