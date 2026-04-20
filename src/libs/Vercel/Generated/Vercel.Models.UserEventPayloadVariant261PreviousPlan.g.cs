
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant261PreviousPlan
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
    public static class UserEventPayloadVariant261PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant261PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant261PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant261PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant261PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant261PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant261PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant261PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant261PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}