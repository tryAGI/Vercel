
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant243Previous
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
    public static class UserEventPayloadVariant243PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant243Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant243Previous.Elastic => "elastic",
                UserEventPayloadVariant243Previous.Enhanced => "enhanced",
                UserEventPayloadVariant243Previous.Standard => "standard",
                UserEventPayloadVariant243Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant243Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant243Previous.Elastic,
                "enhanced" => UserEventPayloadVariant243Previous.Enhanced,
                "standard" => UserEventPayloadVariant243Previous.Standard,
                "turbo" => UserEventPayloadVariant243Previous.Turbo,
                _ => null,
            };
        }
    }
}