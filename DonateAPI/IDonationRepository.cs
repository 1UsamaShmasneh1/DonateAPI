namespace DonateAPI
{
    public interface IDonationRepository
    {
        void AddDonationCount();
        int GetTotalDonationCount();
    }
}