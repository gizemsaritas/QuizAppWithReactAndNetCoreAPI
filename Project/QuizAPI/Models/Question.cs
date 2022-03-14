using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    public class Question
    {
        [Key]
        public int QnId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? QnInWords { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? ImageName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public int Options1 { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public int Options2 { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public int Options3 { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public int Options4 { get; set; }
        public int Answer { get; set; }
    }
}
