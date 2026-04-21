
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedContentHintVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobStoreId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectEnvResponseCreatedContentHintVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedContentHintVariant6Type value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedContentHintVariant6Type.BlobStoreId => "blob-store-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedContentHintVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-store-id" => CreateProjectEnvResponseCreatedContentHintVariant6Type.BlobStoreId,
                _ => null,
            };
        }
    }
}