﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkeWebRazor_Temp.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(30)]
		[DisplayName("Category Name")]
		public string Name { get; set; }
		[Range(1, 100, ErrorMessage = "Waarde moet liggen tussen 1 en 100")]
		[DisplayName("Display Order")]
		public int DisplayOrder { get; set; }
	}
}
