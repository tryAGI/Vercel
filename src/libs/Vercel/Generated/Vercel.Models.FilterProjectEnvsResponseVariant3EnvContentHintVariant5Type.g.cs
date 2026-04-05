
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant3EnvContentHintVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobReadWriteToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant3EnvContentHintVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant3EnvContentHintVariant5Type value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant3EnvContentHintVariant5Type.BlobReadWriteToken => "blob-read-write-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant3EnvContentHintVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-read-write-token" => FilterProjectEnvsResponseVariant3EnvContentHintVariant5Type.BlobReadWriteToken,
                _ => null,
            };
        }
    }
}