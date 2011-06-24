using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using MvcSampleApp1.Helpers;
using MvcSampleApp1.Models;

namespace MvcSampleApp1.Controllers
{
	public class KontaktDetailsCommand : ICommand<Kontakt>
	{
		private readonly IKontaktStore _kontaktStore;

		public KontaktDetailsCommand(IKontaktStore kontaktStore)
		{
			_kontaktStore = kontaktStore;
		}

		public int Id { get; set; }

		public Kontakt Execute()
		{
			return _kontaktStore.GetKontakte().ElementAt(Id);
		}

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			yield break;
		}
	}
}