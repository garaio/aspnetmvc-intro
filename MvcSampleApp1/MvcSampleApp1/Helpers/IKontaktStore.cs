using System.Collections.Generic;

using MvcSampleApp1.Models;

namespace MvcSampleApp1.Helpers
{
	public interface IKontaktStore
	{
		IEnumerable<Kontakt> GetKontakte();

		void AddKontakt(Kontakt kontakt);

		void RemoveKontakt(Kontakt kontakt);
	}
}