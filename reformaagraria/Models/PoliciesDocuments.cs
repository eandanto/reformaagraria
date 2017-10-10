﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class PoliciesDocuments
    {
        public PoliciesDocuments()
        {

        }
        
        [Required]
        [Key]
        public string Id { get; set; }
        
        public string TitleOfDocument { get; set; }
                
        public string Attachment { get; set; }
        
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}