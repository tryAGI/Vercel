
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectEnvItemContentHintVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobWebhookPublicKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectEnvItemContentHintVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectEnvItemContentHintVariant7Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectEnvItemContentHintVariant7Type.BlobWebhookPublicKey => "blob-webhook-public-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectEnvItemContentHintVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-webhook-public-key" => GetProjectsResponseVariant2ProjectEnvItemContentHintVariant7Type.BlobWebhookPublicKey,
                _ => null,
            };
        }
    }
}