﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Students.Models.ViewModels
{
    public class StudentEditViewmodel
    {
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        [MinLength(3, ErrorMessage = "Last Name should be at least 3 characters")]
        public string LastName { get; set; }

        [Display(Name = "Cohort")]
        [Required]
        public int CohortId { get; set; }

        [Display(Name = "Slack Handle")]
        [Required]
        public string SlackHandle { get; set; }
        public List<SelectListItem> CohortOptions { get; set; }
    }
}