using System.ComponentModel.DataAnnotations;

namespace MvcSampleApp1.Models
{
	public class Kontakt
	{
		[Required]
		public string Vorname { get; set; }

		[Required]
		public string Name { get; set; }
		
		public string Strasse { get; set; }

		[Required]
		public string PLZ { get; set; }

		[Required]
		public string Ort { get; set; }

		[Required]
		public string Land { get; set; }
	}
}