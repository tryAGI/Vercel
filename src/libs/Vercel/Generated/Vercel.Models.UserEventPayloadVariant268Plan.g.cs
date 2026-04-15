
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant268Plan
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
    public static class UserEventPayloadVariant268PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant268Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant268Plan.Enterprise => "enterprise",
                UserEventPayloadVariant268Plan.Hobby => "hobby",
                UserEventPayloadVariant268Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant268Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant268Plan.Enterprise,
                "hobby" => UserEventPayloadVariant268Plan.Hobby,
                "pro" => UserEventPayloadVariant268Plan.Pro,
                _ => null,
            };
        }
    }
}