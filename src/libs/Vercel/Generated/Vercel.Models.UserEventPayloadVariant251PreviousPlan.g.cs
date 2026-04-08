
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant251PreviousPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Hobby,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant251PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant251PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant251PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant251PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant251PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant251PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant251PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}