
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant245Previous
    {
        /// <summary>
        /// 
        /// </summary>
        Elastic,
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant245PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant245Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant245Previous.Elastic => "elastic",
                UserEventPayloadVariant245Previous.Enhanced => "enhanced",
                UserEventPayloadVariant245Previous.Standard => "standard",
                UserEventPayloadVariant245Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant245Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant245Previous.Elastic,
                "enhanced" => UserEventPayloadVariant245Previous.Enhanced,
                "standard" => UserEventPayloadVariant245Previous.Standard,
                "turbo" => UserEventPayloadVariant245Previous.Turbo,
                _ => null,
            };
        }
    }
}