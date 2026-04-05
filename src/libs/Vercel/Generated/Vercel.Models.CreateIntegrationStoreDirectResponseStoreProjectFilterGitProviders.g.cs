
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProjectFilterGitProviders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvidersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProjectFilterGitProviders value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProjectFilterGitProviders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProjectFilterGitProviders? ToEnum(string value)
        {
            return value switch
            {
                "*" => CreateIntegrationStoreDirectResponseStoreProjectFilterGitProviders.Multiply,
                _ => null,
            };
        }
    }
}