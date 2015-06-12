using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OmurBlog.Models
{
    public class Makaleler
    {
            public int MakalelerId { get; set; }
            public Makaleler()
            {
                this.Date = DateTime.Now;
            }
            

            [Required(ErrorMessage = "Enter Title please.")]
            [StringLength(50, MinimumLength = 3, ErrorMessage = "Title should be between 3-50 characters.")]
            public string Title { get; set; }

            [Required(ErrorMessage = "Enter Author please.")]
            [StringLength(80, MinimumLength = 3, ErrorMessage = "Author Names should be between 3-80 characters.")]
            public string Author { get; set; }
            public DateTime Date { get; set; }

            [Required(ErrorMessage = "Enter content please.")]
            [DataType(DataType.Html, ErrorMessage = "Enter content in HTML format")]
            public string ArticleContent { get; set; }
        }
    }