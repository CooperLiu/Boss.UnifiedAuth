namespace Boss.UnifiedAuth
{
    public static class UnifiedAuthDbProperties
    {
        public static string DbTablePrefix { get; set; } = "UnifiedAuth";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "UnifiedAuth";
    }
}
