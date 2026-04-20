
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant251Previous
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
    public static class UserEventPayloadVariant251PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant251Previous.Elastic => "elastic",
                UserEventPayloadVariant251Previous.Enhanced => "enhanced",
                UserEventPayloadVariant251Previous.Standard => "standard",
                UserEventPayloadVariant251Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant251Previous.Elastic,
                "enhanced" => UserEventPayloadVariant251Previous.Enhanced,
                "standard" => UserEventPayloadVariant251Previous.Standard,
                "turbo" => UserEventPayloadVariant251Previous.Turbo,
                _ => null,
            };
        }
    }
}