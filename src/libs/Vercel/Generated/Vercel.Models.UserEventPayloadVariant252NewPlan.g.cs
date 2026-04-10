
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant252NewPlan
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
    public static class UserEventPayloadVariant252NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant252NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant252NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant252NewPlan.Hobby => "hobby",
                UserEventPayloadVariant252NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant252NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant252NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant252NewPlan.Hobby,
                "pro" => UserEventPayloadVariant252NewPlan.Pro,
                _ => null,
            };
        }
    }
}