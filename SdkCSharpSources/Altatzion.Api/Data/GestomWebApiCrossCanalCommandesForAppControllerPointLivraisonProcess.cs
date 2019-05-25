using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class PointLivraisonProcess
	{
		public Guid Guid{ get; set; }
		public string Civilite{ get; set; }
		public string Nom{ get; set; }
		public string Adresse{ get; set; }
		public string Ville{ get; set; }
		public string Telephone{ get; set; }
		public string CP{ get; set; }
		public string Email{ get; set; }
		public string Indication{ get; set; }
		public String[] Services{ get; set; }
		public GeoLocalisationPointLivraisonProcess Localisation{ get; set; }
		public bool EstActif{ get; set; }
	}
}
