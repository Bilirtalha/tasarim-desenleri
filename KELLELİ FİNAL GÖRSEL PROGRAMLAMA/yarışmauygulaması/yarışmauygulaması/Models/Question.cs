using System.Linq;

namespace yarışmauygulaması.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionName { get; set; }
        public string QuestionAnswer { get; set; }
        public string QuestionChoices { get; set; }
        public string[] QuestionChoicesArray {get;set;}
        public Question()
        {
            QuestionChoicesArray = QuestionChoices !=null? QuestionChoices.Split(',') : null;
        }
    }
}
