
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant264NewPlan
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
    public static class UserEventPayloadVariant264NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant264NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant264NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant264NewPlan.Hobby => "hobby",
                UserEventPayloadVariant264NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant264NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant264NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant264NewPlan.Hobby,
                "pro" => UserEventPayloadVariant264NewPlan.Pro,
                _ => null,
            };
        }
    }
}