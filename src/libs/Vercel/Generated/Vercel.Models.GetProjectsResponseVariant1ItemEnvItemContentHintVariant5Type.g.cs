
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemEnvItemContentHintVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobReadWriteToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemEnvItemContentHintVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemEnvItemContentHintVariant5Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemEnvItemContentHintVariant5Type.BlobReadWriteToken => "blob-read-write-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemEnvItemContentHintVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-read-write-token" => GetProjectsResponseVariant1ItemEnvItemContentHintVariant5Type.BlobReadWriteToken,
                _ => null,
            };
        }
    }
}