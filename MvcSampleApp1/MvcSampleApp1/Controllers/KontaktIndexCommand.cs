using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using MvcSampleApp1.Helpers;
using MvcSampleApp1.Models;

namespace MvcSampleApp1.Controllers
{
	public class KontaktIndexCommand : ICommand<IEnumerable<Kontakt>>
	{
		private readonly IKontaktStore _kontaktStore;

		public KontaktIndexCommand(IKontaktStore kontaktStore)
		{
			_kontaktStore = kontaktStore;
		}

		public IEnumerable<Kontakt> Execute()
		{
			return _kontaktStore.GetKontakte();
		}

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			yield break;
		}
	}
}