
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant274NewPlan
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
    public static class UserEventPayloadVariant274NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant274NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant274NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant274NewPlan.Hobby => "hobby",
                UserEventPayloadVariant274NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant274NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant274NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant274NewPlan.Hobby,
                "pro" => UserEventPayloadVariant274NewPlan.Pro,
                _ => null,
            };
        }
    }
}