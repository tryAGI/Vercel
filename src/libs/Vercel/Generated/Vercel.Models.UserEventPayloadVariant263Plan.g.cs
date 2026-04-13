
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant263Plan
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
    public static class UserEventPayloadVariant263PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant263Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant263Plan.Enterprise => "enterprise",
                UserEventPayloadVariant263Plan.Hobby => "hobby",
                UserEventPayloadVariant263Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant263Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant263Plan.Enterprise,
                "hobby" => UserEventPayloadVariant263Plan.Hobby,
                "pro" => UserEventPayloadVariant263Plan.Pro,
                _ => null,
            };
        }
    }
}