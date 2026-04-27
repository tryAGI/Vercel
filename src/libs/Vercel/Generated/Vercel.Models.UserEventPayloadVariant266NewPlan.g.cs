
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant266NewPlan
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
    public static class UserEventPayloadVariant266NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant266NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant266NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant266NewPlan.Hobby => "hobby",
                UserEventPayloadVariant266NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant266NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant266NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant266NewPlan.Hobby,
                "pro" => UserEventPayloadVariant266NewPlan.Pro,
                _ => null,
            };
        }
    }
}