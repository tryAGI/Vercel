
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant250Previous
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
    public static class UserEventPayloadVariant250PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant250Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant250Previous.Elastic => "elastic",
                UserEventPayloadVariant250Previous.Enhanced => "enhanced",
                UserEventPayloadVariant250Previous.Standard => "standard",
                UserEventPayloadVariant250Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant250Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant250Previous.Elastic,
                "enhanced" => UserEventPayloadVariant250Previous.Enhanced,
                "standard" => UserEventPayloadVariant250Previous.Standard,
                "turbo" => UserEventPayloadVariant250Previous.Turbo,
                _ => null,
            };
        }
    }
}