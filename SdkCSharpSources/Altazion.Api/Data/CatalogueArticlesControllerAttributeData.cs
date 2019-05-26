using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données AttributeData
	///</summary>
	public class AttributeData
	{
		///<summary>
		///Obtient ou définit la valeur Name
		///</summary>
		public string Name{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Group
		///</summary>
		public string Group{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Id
		///</summary>
		public string Id{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Type
		///</summary>
		public AttributeType Type{ get; set; }

	}
}
