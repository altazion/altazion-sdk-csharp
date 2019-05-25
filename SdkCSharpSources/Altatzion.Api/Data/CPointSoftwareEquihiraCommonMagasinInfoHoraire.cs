using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class Horaire
	{
		public string Jour{ get; set; }
		public bool Ouvert{ get; set; }
		public TimeSpan Ouverture{ get; set; }
		public System.TimeSpan? FermertureMidi{ get; set; }
		public System.TimeSpan? ReouvertureMidi{ get; set; }
		public TimeSpan Fermeture{ get; set; }
	}
}
