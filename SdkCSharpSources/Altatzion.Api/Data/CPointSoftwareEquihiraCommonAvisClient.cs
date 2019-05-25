using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class AvisClient
	{
		public Guid Guid{ get; set; }
		public Guid ArticleGuid{ get; set; }
		public string Nom{ get; set; }
		public string Message{ get; set; }
		public Guid? ClientGuid{ get; set; }
		public string Email{ get; set; }
		public bool EstValide{ get; set; }
		public DateTime Date{ get; set; }
		public decimal Note{ get; set; }
	}
}
