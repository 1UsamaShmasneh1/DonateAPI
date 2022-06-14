namespace DonateAPI
{
    public class DonationRepository: IDonationRepository
    {
        private int TotalDonation { get; set; } = 0;
        public void AddDonationCount()
        {
            TotalDonation++;
        }

        public int GetTotalDonationCount()
        {
            return TotalDonation;
        }
    }
}
