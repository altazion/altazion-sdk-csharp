using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class PubliciteItem
	{
		public string Emplacement{ get; set; }
		public string ImageUrl{ get; set; }
		public string DestinationUrl{ get; set; }
		public string Contexte{ get; set; }
		public System.Int32? Largeur{ get; set; }
		public System.Int32? Hauteur{ get; set; }
		public string Titre{ get; set; }
		public string TypeMime{ get; set; }
	}
}
