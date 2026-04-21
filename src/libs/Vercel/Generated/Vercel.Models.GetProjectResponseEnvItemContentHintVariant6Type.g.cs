
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseEnvItemContentHintVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobStoreId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseEnvItemContentHintVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseEnvItemContentHintVariant6Type value)
        {
            return value switch
            {
                GetProjectResponseEnvItemContentHintVariant6Type.BlobStoreId => "blob-store-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseEnvItemContentHintVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-store-id" => GetProjectResponseEnvItemContentHintVariant6Type.BlobStoreId,
                _ => null,
            };
        }
    }
}