using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Stock.Model.Entities;

namespace Stock.Api.DTOs {
    public class ProviderDTO {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Phone { get; set; }

        public string Email { get; set; }
    }
}