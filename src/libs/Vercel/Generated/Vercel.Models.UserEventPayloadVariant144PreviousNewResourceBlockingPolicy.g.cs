
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant144PreviousNewResourceBlockingPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Block,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant144PreviousNewResourceBlockingPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant144PreviousNewResourceBlockingPolicy value)
        {
            return value switch
            {
                UserEventPayloadVariant144PreviousNewResourceBlockingPolicy.Allow => "allow",
                UserEventPayloadVariant144PreviousNewResourceBlockingPolicy.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant144PreviousNewResourceBlockingPolicy? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UserEventPayloadVariant144PreviousNewResourceBlockingPolicy.Allow,
                "block" => UserEventPayloadVariant144PreviousNewResourceBlockingPolicy.Block,
                _ => null,
            };
        }
    }
}