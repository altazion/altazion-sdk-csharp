using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class MediationMessage
	{
		public DateTimeOffset Date{ get; set; }
		public string Message{ get; set; }
		public MediationMessageKind Kind{ get; set; }
	}
}
