using System;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class ProductComment
    {
        [Key]
        public int ProductCommentId { get; set; }

        // Foreign Key
        public int ProductId { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required]
        public DateTime CommentDate { get; set; }


        // External
        public Product Product { get; set; }
    }
}