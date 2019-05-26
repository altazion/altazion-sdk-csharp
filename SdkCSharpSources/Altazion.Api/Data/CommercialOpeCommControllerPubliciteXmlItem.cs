using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données PubliciteXmlItem
	///</summary>
	public class PubliciteXmlItem
	{
		///<summary>
		///Obtient ou définit la valeur TemplateCode
		///</summary>
		public string TemplateCode{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Variables
		///</summary>
		public PubliciteXmlVariable[] Variables{ get; set; }

	}
}
