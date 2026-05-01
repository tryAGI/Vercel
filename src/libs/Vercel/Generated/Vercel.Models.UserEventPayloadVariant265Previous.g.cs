
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant265Previous
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
    public static class UserEventPayloadVariant265PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant265Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant265Previous.Elastic => "elastic",
                UserEventPayloadVariant265Previous.Enhanced => "enhanced",
                UserEventPayloadVariant265Previous.Standard => "standard",
                UserEventPayloadVariant265Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant265Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant265Previous.Elastic,
                "enhanced" => UserEventPayloadVariant265Previous.Enhanced,
                "standard" => UserEventPayloadVariant265Previous.Standard,
                "turbo" => UserEventPayloadVariant265Previous.Turbo,
                _ => null,
            };
        }
    }
}