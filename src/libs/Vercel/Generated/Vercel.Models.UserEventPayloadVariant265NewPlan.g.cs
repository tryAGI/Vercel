
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant265NewPlan
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
    public static class UserEventPayloadVariant265NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant265NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant265NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant265NewPlan.Hobby => "hobby",
                UserEventPayloadVariant265NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant265NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant265NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant265NewPlan.Hobby,
                "pro" => UserEventPayloadVariant265NewPlan.Pro,
                _ => null,
            };
        }
    }
}