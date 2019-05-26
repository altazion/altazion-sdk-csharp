using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données TagValueData
	///</summary>
	public class TagValueData
	{
		///<summary>
		///Obtient ou définit la valeur TextData
		///</summary>
		public string TextData{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ValueGuid
		///</summary>
		public Guid ValueGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur HtmlData
		///</summary>
		public string HtmlData{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ImageUrl
		///</summary>
		public string ImageUrl{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ColorData
		///</summary>
		public string ColorData{ get; set; }

	}
}
