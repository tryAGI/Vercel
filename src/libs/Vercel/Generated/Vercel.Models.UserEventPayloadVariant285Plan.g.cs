
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant285Plan
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
    public static class UserEventPayloadVariant285PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant285Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant285Plan.Enterprise => "enterprise",
                UserEventPayloadVariant285Plan.Hobby => "hobby",
                UserEventPayloadVariant285Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant285Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant285Plan.Enterprise,
                "hobby" => UserEventPayloadVariant285Plan.Hobby,
                "pro" => UserEventPayloadVariant285Plan.Pro,
                _ => null,
            };
        }
    }
}