
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant270Plan
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
    public static class UserEventPayloadVariant270PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant270Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant270Plan.Enterprise => "enterprise",
                UserEventPayloadVariant270Plan.Hobby => "hobby",
                UserEventPayloadVariant270Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant270Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant270Plan.Enterprise,
                "hobby" => UserEventPayloadVariant270Plan.Hobby,
                "pro" => UserEventPayloadVariant270Plan.Pro,
                _ => null,
            };
        }
    }
}