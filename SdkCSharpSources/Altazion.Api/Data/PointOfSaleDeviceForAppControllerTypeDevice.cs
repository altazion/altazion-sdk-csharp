using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données TypeDevice
	///</summary>
	public class TypeDevice
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Label
		///</summary>
		public string Label{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Kind
		///</summary>
		public PosteTypeEcran Kind{ get; set; }

	}
}
