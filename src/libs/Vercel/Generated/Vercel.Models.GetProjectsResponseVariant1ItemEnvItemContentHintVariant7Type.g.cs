
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemEnvItemContentHintVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobWebhookPublicKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemEnvItemContentHintVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemEnvItemContentHintVariant7Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemEnvItemContentHintVariant7Type.BlobWebhookPublicKey => "blob-webhook-public-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemEnvItemContentHintVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-webhook-public-key" => GetProjectsResponseVariant1ItemEnvItemContentHintVariant7Type.BlobWebhookPublicKey,
                _ => null,
            };
        }
    }
}