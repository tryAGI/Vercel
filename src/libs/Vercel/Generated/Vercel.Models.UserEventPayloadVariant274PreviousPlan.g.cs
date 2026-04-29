
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant274PreviousPlan
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
    public static class UserEventPayloadVariant274PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant274PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant274PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant274PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant274PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant274PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant274PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant274PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant274PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}