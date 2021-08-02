using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.Models.Entities
{
    public class Album
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, 
            ErrorMessage = "Album name should have at least 1 character")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "smallmoney")] //smallmoney max value is up to 214,748.3647
        public decimal Price { get; set; }
        
        [Required]
        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        public string ImageName { get; set; }

        
        //Fully-defined relationship with Band
        public Guid BandId { get; set; }
        public Band Band { get; set; }

        //One-to-one relationship with Tracklist
        public Tracklist Tracklist { get; set; }
    }
}