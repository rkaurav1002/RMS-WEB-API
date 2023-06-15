using System.ComponentModel.DataAnnotations;

namespace AdminAPI.Models
{
    public class AddQuestionViewModel
    {
        
        public int QuestionId { get; set; }  //QuestionId
        public int QuestionNumber { get; set; }
        public string Quest { get; set; }
        public string QuestionType { get; set; }
        public string Category { get; set; }
        public int Weightage { get; set; }
        public string Active { get; set; }
        public string QuestionSet  { get; set; }
        public string QuestionSetLastModifiedBy  { get; set; }
        public DateTime LastModifiedOn  { get; set; }
        
        
        // public int QuestionNumber { get; set; }

        // public string Quest { get; set; }

        // public string Answer { get; set; }

        // public string QuestionType { get; set; }

        // public string Category { get; set; }

        // public int Weightage { get; set; }

        // public bool Active { 
            
        //     get; set; 
        // }

        // public string QuestionSet { get; set; }

        // public string ModifiedBy { get; set; }

        // public DateTime ModifiedOn { get; set; }
    }
}
