using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class ModeReglement
	{
		public Guid Guid{ get; set; }
		public string Libelle{ get; set; }
		public TypeReglement Type{ get; set; }
		public bool EstPrincipal{ get; set; }
		public int Priorite{ get; set; }
		public bool EstModifiable{ get; set; }
		public bool AvecDetail{ get; set; }
		public ModeReglementDetail[] ListeDetail{ get; set; }
	}
}
