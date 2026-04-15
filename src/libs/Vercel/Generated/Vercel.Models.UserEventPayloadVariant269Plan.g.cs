
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant269Plan
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
    public static class UserEventPayloadVariant269PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant269Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant269Plan.Enterprise => "enterprise",
                UserEventPayloadVariant269Plan.Hobby => "hobby",
                UserEventPayloadVariant269Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant269Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant269Plan.Enterprise,
                "hobby" => UserEventPayloadVariant269Plan.Hobby,
                "pro" => UserEventPayloadVariant269Plan.Pro,
                _ => null,
            };
        }
    }
}