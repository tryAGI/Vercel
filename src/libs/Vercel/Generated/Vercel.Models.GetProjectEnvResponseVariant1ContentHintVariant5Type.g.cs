
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant1ContentHintVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobReadWriteToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectEnvResponseVariant1ContentHintVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant1ContentHintVariant5Type value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant1ContentHintVariant5Type.BlobReadWriteToken => "blob-read-write-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant1ContentHintVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-read-write-token" => GetProjectEnvResponseVariant1ContentHintVariant5Type.BlobReadWriteToken,
                _ => null,
            };
        }
    }
}