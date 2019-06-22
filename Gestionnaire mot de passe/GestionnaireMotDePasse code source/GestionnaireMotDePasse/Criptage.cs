using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireMotDePasse
{
	class Criptage
	{
		public string Hash(string ToHash)
		{
			string Hash = "";
			foreach (char c in ToHash)
			{
				double temp = (int)c;
				temp *= 5;
				Hash += (char)temp;
			}
			return Hash;
		}

		public string UnHash(string ToUnHash)
		{
			string UnHash = "";
			foreach (char c in ToUnHash)
			{
				double temp = (int)c;
				temp /= 5;
				UnHash += (char)temp;
			}
			return UnHash;
		}
	}
}
