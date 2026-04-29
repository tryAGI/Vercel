
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant10ToPlan
    {
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
    public static class UserEventPayloadVariant10ToPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant10ToPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant10ToPlan.Hobby => "hobby",
                UserEventPayloadVariant10ToPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant10ToPlan? ToEnum(string value)
        {
            return value switch
            {
                "hobby" => UserEventPayloadVariant10ToPlan.Hobby,
                "pro" => UserEventPayloadVariant10ToPlan.Pro,
                _ => null,
            };
        }
    }
}