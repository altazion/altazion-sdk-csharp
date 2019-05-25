using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class MailCheckResult
	{
		public bool EstDejaExistante{ get; set; }
		public string Suggestion{ get; set; }
		public bool AvantagesFideliteDisponibles{ get; set; }
		public string Source{ get; set; }
		public bool EstInvalide{ get; set; }
		public bool EstAvecCompteClient{ get; set; }
		public bool EstGuest{ get; set; }
	}
}
