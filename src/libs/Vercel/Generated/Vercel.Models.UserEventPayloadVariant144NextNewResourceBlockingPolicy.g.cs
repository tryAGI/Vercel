
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant144NextNewResourceBlockingPolicy
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
    public static class UserEventPayloadVariant144NextNewResourceBlockingPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant144NextNewResourceBlockingPolicy value)
        {
            return value switch
            {
                UserEventPayloadVariant144NextNewResourceBlockingPolicy.Allow => "allow",
                UserEventPayloadVariant144NextNewResourceBlockingPolicy.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant144NextNewResourceBlockingPolicy? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UserEventPayloadVariant144NextNewResourceBlockingPolicy.Allow,
                "block" => UserEventPayloadVariant144NextNewResourceBlockingPolicy.Block,
                _ => null,
            };
        }
    }
}