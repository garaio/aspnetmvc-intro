using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MvcSampleApp1.Models;

namespace MvcSampleApp1.Helpers
{
	public class KontaktStore : IKontaktStore
	{
		private readonly List<Kontakt> _kontakte = new List<Kontakt>();

		public IEnumerable<Kontakt> GetKontakte()
		{
			return _kontakte.AsReadOnly();
		}

		public void AddKontakt(Kontakt kontakt)
		{
			_kontakte.Add(kontakt);
		}

		public void RemoveKontakt(Kontakt kontakt)
		{
			_kontakte.Remove(kontakt);
		}
	}
}