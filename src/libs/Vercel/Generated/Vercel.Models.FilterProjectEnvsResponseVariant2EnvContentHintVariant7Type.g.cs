
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant2EnvContentHintVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobWebhookPublicKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant2EnvContentHintVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant2EnvContentHintVariant7Type value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant2EnvContentHintVariant7Type.BlobWebhookPublicKey => "blob-webhook-public-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant2EnvContentHintVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-webhook-public-key" => FilterProjectEnvsResponseVariant2EnvContentHintVariant7Type.BlobWebhookPublicKey,
                _ => null,
            };
        }
    }
}