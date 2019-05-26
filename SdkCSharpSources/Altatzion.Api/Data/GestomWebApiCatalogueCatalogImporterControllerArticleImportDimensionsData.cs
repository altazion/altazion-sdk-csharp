using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticleImportDimensionsData
	///</summary>
	public class ArticleImportDimensionsData
	{
		///<summary>
		///Obtient ou définit la valeur PoidsEnG
		///</summary>
		public decimal PoidsEnG{ get; set; }

		///<summary>
		///Obtient ou définit la valeur HauteurEnCm
		///</summary>
		public decimal HauteurEnCm{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ProfondeurEnCm
		///</summary>
		public decimal ProfondeurEnCm{ get; set; }

		///<summary>
		///Obtient ou définit la valeur LargeurEnCm
		///</summary>
		public decimal LargeurEnCm{ get; set; }

	}
}
