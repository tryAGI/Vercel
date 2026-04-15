
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant260PreviousPlan
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
    public static class UserEventPayloadVariant260PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant260PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant260PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant260PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant260PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant260PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant260PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant260PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant260PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}