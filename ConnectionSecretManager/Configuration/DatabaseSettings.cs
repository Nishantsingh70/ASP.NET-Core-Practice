namespace ConnectionSecretManager.Configuration
{
    public class DatabaseSettings
    {
        public const string SectionName = "ConnectionStrings";

        public string DefaultConnection { get; set; } = default!;
    }
}

// secret is stored in user secrets.json file