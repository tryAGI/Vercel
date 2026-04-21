
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseEnvItemContentHintVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobStoreId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseEnvItemContentHintVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseEnvItemContentHintVariant6Type value)
        {
            return value switch
            {
                CreateProjectResponseEnvItemContentHintVariant6Type.BlobStoreId => "blob-store-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseEnvItemContentHintVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-store-id" => CreateProjectResponseEnvItemContentHintVariant6Type.BlobStoreId,
                _ => null,
            };
        }
    }
}