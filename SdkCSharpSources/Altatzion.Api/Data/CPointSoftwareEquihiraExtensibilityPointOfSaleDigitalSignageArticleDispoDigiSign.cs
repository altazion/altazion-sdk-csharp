using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class ArticleDispoDigiSign
	{
		public Guid? MagasinGuid{ get; set; }
		public string Libelle{ get; set; }
		public bool EstDisponible{ get; set; }
		public string Commentaire{ get; set; }
		public decimal? Stock{ get; set; }
	}
}
