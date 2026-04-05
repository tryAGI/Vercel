
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant68JobVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        BitbucketNowComment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant68JobVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant68JobVariant2Type value)
        {
            return value switch
            {
                UserEventPayloadVariant68JobVariant2Type.BitbucketNowComment => "bitbucket-now-comment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant68JobVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket-now-comment" => UserEventPayloadVariant68JobVariant2Type.BitbucketNowComment,
                _ => null,
            };
        }
    }
}