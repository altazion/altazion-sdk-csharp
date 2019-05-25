using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class TypeDevice
	{
		public Guid Guid{ get; set; }
		public string Label{ get; set; }
		public PosteTypeEcran Kind{ get; set; }
	}
}
