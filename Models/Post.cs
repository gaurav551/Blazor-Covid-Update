using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
         [Required]
        public string  Description { get; set; }
        public DateTime PostedOn{ get; set; } = DateTime.Now;
         [Required]
        public string Category { get; set; }
         [Required]
        public string AuthorName { get; set; }

    }
}