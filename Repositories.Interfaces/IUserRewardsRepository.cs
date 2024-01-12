namespace Gamification.Repositories.Interfaces
{
    public interface IUserRewardsRepository
    {
        int GetPointsById(string userId);
        double GetXpById(string userId);
    }
}
