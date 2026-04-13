
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant254NewPlan
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
    public static class UserEventPayloadVariant254NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant254NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant254NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant254NewPlan.Hobby => "hobby",
                UserEventPayloadVariant254NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant254NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant254NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant254NewPlan.Hobby,
                "pro" => UserEventPayloadVariant254NewPlan.Pro,
                _ => null,
            };
        }
    }
}