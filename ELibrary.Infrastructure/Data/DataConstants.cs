namespace ELibrary.Infrastructure.Data
{
    public static class DataConstants
    {
        // Resource entity constraints
        public const long RESOURCE_FILE_MAX_SIZE = 20 * 1024 * 1024; // 20MB
        public static readonly HashSet<string> RESOURCE_FILE_ALLOWED_EXTENSIONS = new(StringComparer.OrdinalIgnoreCase) { "test", "test2" };
    }
}
