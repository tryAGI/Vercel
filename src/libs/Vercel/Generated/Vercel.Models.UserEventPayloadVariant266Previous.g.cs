
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant266Previous
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
    public static class UserEventPayloadVariant266PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant266Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant266Previous.Elastic => "elastic",
                UserEventPayloadVariant266Previous.Enhanced => "enhanced",
                UserEventPayloadVariant266Previous.Standard => "standard",
                UserEventPayloadVariant266Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant266Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant266Previous.Elastic,
                "enhanced" => UserEventPayloadVariant266Previous.Enhanced,
                "standard" => UserEventPayloadVariant266Previous.Standard,
                "turbo" => UserEventPayloadVariant266Previous.Turbo,
                _ => null,
            };
        }
    }
}