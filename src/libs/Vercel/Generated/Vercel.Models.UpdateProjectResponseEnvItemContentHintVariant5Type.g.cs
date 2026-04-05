
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseEnvItemContentHintVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobReadWriteToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseEnvItemContentHintVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseEnvItemContentHintVariant5Type value)
        {
            return value switch
            {
                UpdateProjectResponseEnvItemContentHintVariant5Type.BlobReadWriteToken => "blob-read-write-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseEnvItemContentHintVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-read-write-token" => UpdateProjectResponseEnvItemContentHintVariant5Type.BlobReadWriteToken,
                _ => null,
            };
        }
    }
}