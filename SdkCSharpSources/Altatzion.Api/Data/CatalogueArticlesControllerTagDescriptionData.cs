using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données TagDescriptionData
	///</summary>
	public class TagDescriptionData
	{
		///<summary>
		///Obtient ou définit la valeur Title
		///</summary>
		public string Title{ get; set; }

		///<summary>
		///Obtient ou définit la valeur LabelGuid
		///</summary>
		public Guid LabelGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur IsOldTag
		///</summary>
		public bool IsOldTag{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Values
		///</summary>
		public TagValueData[] Values{ get; set; }

	}
}
