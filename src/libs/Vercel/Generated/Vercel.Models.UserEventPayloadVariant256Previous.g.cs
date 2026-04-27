
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant256Previous
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
    public static class UserEventPayloadVariant256PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant256Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant256Previous.Elastic => "elastic",
                UserEventPayloadVariant256Previous.Enhanced => "enhanced",
                UserEventPayloadVariant256Previous.Standard => "standard",
                UserEventPayloadVariant256Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant256Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant256Previous.Elastic,
                "enhanced" => UserEventPayloadVariant256Previous.Enhanced,
                "standard" => UserEventPayloadVariant256Previous.Standard,
                "turbo" => UserEventPayloadVariant256Previous.Turbo,
                _ => null,
            };
        }
    }
}