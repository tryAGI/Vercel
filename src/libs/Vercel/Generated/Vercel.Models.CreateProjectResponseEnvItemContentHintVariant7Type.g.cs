
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseEnvItemContentHintVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        BlobWebhookPublicKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseEnvItemContentHintVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseEnvItemContentHintVariant7Type value)
        {
            return value switch
            {
                CreateProjectResponseEnvItemContentHintVariant7Type.BlobWebhookPublicKey => "blob-webhook-public-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseEnvItemContentHintVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "blob-webhook-public-key" => CreateProjectResponseEnvItemContentHintVariant7Type.BlobWebhookPublicKey,
                _ => null,
            };
        }
    }
}