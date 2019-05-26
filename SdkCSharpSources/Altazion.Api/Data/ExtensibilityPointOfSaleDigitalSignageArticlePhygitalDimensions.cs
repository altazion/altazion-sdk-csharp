using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticlePhygitalDimensions
	///</summary>
	public class ArticlePhygitalDimensions
	{
		///<summary>
		///Obtient ou définit la valeur PoidsBrut
		///</summary>
		public decimal PoidsBrut{ get; set; }

		///<summary>
		///Obtient ou définit la valeur HauteurBrut
		///</summary>
		public decimal HauteurBrut{ get; set; }

		///<summary>
		///Obtient ou définit la valeur LargeurBrut
		///</summary>
		public decimal LargeurBrut{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ProfondeurBrut
		///</summary>
		public decimal ProfondeurBrut{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PoidsNet
		///</summary>
		public decimal? PoidsNet{ get; set; }

		///<summary>
		///Obtient ou définit la valeur HauteurNet
		///</summary>
		public decimal? HauteurNet{ get; set; }

		///<summary>
		///Obtient ou définit la valeur LargeurNet
		///</summary>
		public decimal? LargeurNet{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ProfondeurNet
		///</summary>
		public decimal? ProfondeurNet{ get; set; }

	}
}
