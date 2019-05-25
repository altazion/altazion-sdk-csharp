using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public enum CommandeEtat
	{
		EnAttente = 0,
		EnTraitement = 1,
		Traite = 2,
		Termine = 3,
	}
}
