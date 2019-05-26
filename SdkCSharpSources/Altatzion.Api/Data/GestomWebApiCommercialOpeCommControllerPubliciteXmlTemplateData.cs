using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données PubliciteXmlTemplateData
	///</summary>
	public class PubliciteXmlTemplateData
	{
		///<summary>
		///Obtient ou définit la valeur TemplateCode
		///</summary>
		public string TemplateCode{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Parametres
		///</summary>
		public PubliciteXmlParametre[] Parametres{ get; set; }

		///<summary>
		///Obtient ou définit la valeur NewElement
		///</summary>
		public PubliciteXmlItem NewElement{ get; set; }

	}
}
