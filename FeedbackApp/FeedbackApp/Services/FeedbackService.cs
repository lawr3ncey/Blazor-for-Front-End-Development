using FeedbackApp.Models;
using System.Collections.Generic;

namespace FeedbackApp.Services
{
    public class FeedbackService
    {
        private List<Feedback> feedbackList = new List<Feedback>();
        
        public void AddFeedback(Feedback feedback)
        {
            feedbackList.Add(feedback);
        }   
        
        public IEnumerable<Feedback> GetFeedback() //IEnumerable permite ver los elementos sin permitir modificaciones
        {
            return feedbackList;
        }
    }
}