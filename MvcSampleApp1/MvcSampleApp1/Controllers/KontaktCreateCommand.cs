using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

using MvcSampleApp1.Helpers;
using MvcSampleApp1.Models;

namespace MvcSampleApp1.Controllers
{
	public class KontaktCreateCommand : Kontakt, ICommand
	{
		private readonly IKontaktStore _kontaktStore;

		public KontaktCreateCommand(IKontaktStore kontaktStore)
		{
			_kontaktStore = kontaktStore;
		}

		public void Execute()
		{
			_kontaktStore.AddKontakt(this);
		}

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			yield break;
		}
	}
}