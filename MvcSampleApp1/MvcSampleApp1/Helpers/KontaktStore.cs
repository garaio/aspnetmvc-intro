using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MvcSampleApp1.Models;

namespace MvcSampleApp1.Helpers
{
	public static class KontaktStore
	{
		private static readonly List<Kontakt> _kontakte = new List<Kontakt>();

		public static IEnumerable<Kontakt> GetKontakte()
		{
			return _kontakte.AsReadOnly();
		}

		public static void AddKontakt(Kontakt kontakt)
		{
			_kontakte.Add(kontakt);
		}

		public static void RemoveKontakt(Kontakt kontakt)
		{
			_kontakte.Remove(kontakt);
		}
	}
}