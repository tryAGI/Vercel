
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant252Previous
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
    public static class UserEventPayloadVariant252PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant252Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant252Previous.Elastic => "elastic",
                UserEventPayloadVariant252Previous.Enhanced => "enhanced",
                UserEventPayloadVariant252Previous.Standard => "standard",
                UserEventPayloadVariant252Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant252Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant252Previous.Elastic,
                "enhanced" => UserEventPayloadVariant252Previous.Enhanced,
                "standard" => UserEventPayloadVariant252Previous.Standard,
                "turbo" => UserEventPayloadVariant252Previous.Turbo,
                _ => null,
            };
        }
    }
}