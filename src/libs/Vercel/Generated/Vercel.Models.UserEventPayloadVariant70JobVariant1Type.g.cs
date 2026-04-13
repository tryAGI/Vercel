
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant70JobVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        BitbucketPush,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant70JobVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant70JobVariant1Type value)
        {
            return value switch
            {
                UserEventPayloadVariant70JobVariant1Type.BitbucketPush => "bitbucket-push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant70JobVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket-push" => UserEventPayloadVariant70JobVariant1Type.BitbucketPush,
                _ => null,
            };
        }
    }
}