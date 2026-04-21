
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant271Plan
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
    public static class UserEventPayloadVariant271PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant271Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant271Plan.Enterprise => "enterprise",
                UserEventPayloadVariant271Plan.Hobby => "hobby",
                UserEventPayloadVariant271Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant271Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant271Plan.Enterprise,
                "hobby" => UserEventPayloadVariant271Plan.Hobby,
                "pro" => UserEventPayloadVariant271Plan.Pro,
                _ => null,
            };
        }
    }
}