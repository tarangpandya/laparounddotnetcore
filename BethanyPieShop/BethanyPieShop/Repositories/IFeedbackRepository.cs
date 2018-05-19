using BethanyPieShop.Models;

namespace BethanyPieShop.Repositories
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
