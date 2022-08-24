namespace BuyGroceriesOnline.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext appDbContext;

        public FeedbackRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Feedback DeleteFeedback(int feedbackId)
        {
            var feedback = FeedbackDetails(feedbackId);
            var entry = appDbContext.Feedbacks.Remove(feedback);
            appDbContext.SaveChanges();
            return entry.Entity;
        }

        public Feedback FeedbackDetails(int feedbackId)
        {
            return GetAllFeedback().FirstOrDefault(feedback => feedback.FeedbackId == feedbackId);
        }

        public IEnumerable<Feedback> GetAllFeedback()
        {
            var allFeedback = appDbContext.Feedbacks;
            return allFeedback;
        }

        public Feedback InsertFeedback(Feedback feedback)
        {          
            var insert = this.appDbContext.Feedbacks.Add(feedback);
            this.appDbContext.SaveChanges();
            return insert.Entity;
        }
    }
}
