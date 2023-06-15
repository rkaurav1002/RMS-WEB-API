using System.ComponentModel.DataAnnotations;

namespace AdminAPI.Models;
    public class Question
    {

        
        //public int Questionnaire_Id {get; set;}
        [Key]
        public int QuestionId { get; set; }  //QuestionId
        [Required]
        public int QuestionNumber { get; set; }
        [Required]
        public string Quest { get; set; }
        [Required]
        public string QuestionType { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Weightage { get; set; }
        [Required]
        public string Active { get; set; }
        [Required]
        public string QuestionSet  { get; set; }
        [Required]
        public string QuestionSetLastModifiedBy  { get; set; }
        [Required]
        public DateTime LastModifiedOn  { get; set; }


    }

