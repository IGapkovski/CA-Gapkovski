using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.API.Models
{
    [Table("Books")]
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Author { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string ImageUrl { get; set; }
        
        public int CategoryID { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }

        public Category Category { get; set; }

        [StringLength(10)]
        public string Price { get; set; }
        public DateTime IssueDate { get; set; }

    }
}
