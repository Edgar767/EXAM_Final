using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EXAM.DTOs.Question
{
    public class UpdateQuestionDto
    {
        public string QuestionTxt { get; set; } = null!;

        public string QuestionType { get; set; } = null!;

        public int SurveyId { get; set; }
    }
}
