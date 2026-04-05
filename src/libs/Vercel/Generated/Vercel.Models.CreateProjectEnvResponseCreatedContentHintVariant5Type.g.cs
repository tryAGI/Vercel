
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedContentHintVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobReadWriteToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectEnvResponseCreatedContentHintVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedContentHintVariant5Type value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedContentHintVariant5Type.BlobReadWriteToken => "blob-read-write-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedContentHintVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-read-write-token" => CreateProjectEnvResponseCreatedContentHintVariant5Type.BlobReadWriteToken,
                _ => null,
            };
        }
    }
}