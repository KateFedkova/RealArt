using System.Configuration;

namespace RealArt
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\.."));
            
            string? artists = ConfigurationManager.AppSettings["PathToArtistsData"];
            string? collectors = ConfigurationManager.AppSettings["PathToCollectorsData"];
            string? museums = ConfigurationManager.AppSettings["PathToMuseumsData"];
            string? organisations = ConfigurationManager.AppSettings["PathToOrganisationsData"];
            string? paintings = ConfigurationManager.AppSettings["PathToPaintingsData"];
            string? auctions = ConfigurationManager.AppSettings["PathToAuctionsData"];
           
            string ArtistsData = Path.Combine(projectRoot, artists);
            string CollectorsData = Path.Combine(projectRoot, collectors);
            string MuseumsData = Path.Combine(projectRoot, museums);
            string OrganisationsData = Path.Combine(projectRoot, organisations);
            string PaintingsData = Path.Combine(projectRoot, paintings);
            string AuctionsData = Path.Combine(projectRoot, auctions);

            if (!File.Exists(ArtistsData)) File.WriteAllText(ArtistsData, string.Empty);

            if (!File.Exists(CollectorsData)) File.WriteAllText(CollectorsData, string.Empty);

            if (!File.Exists(MuseumsData)) File.WriteAllText(MuseumsData, string.Empty);

            if (!File.Exists(OrganisationsData)) File.WriteAllText(OrganisationsData, string.Empty);

            if (!File.Exists(PaintingsData)) File.WriteAllText(PaintingsData, string.Empty);

            if (!File.Exists(AuctionsData)) File.WriteAllText(AuctionsData, string.Empty);

            Application.Run(new MainForm());
        }
    }
}