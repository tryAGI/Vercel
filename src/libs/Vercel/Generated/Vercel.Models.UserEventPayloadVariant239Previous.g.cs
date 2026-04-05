
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant239Previous
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
    public static class UserEventPayloadVariant239PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant239Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant239Previous.Elastic => "elastic",
                UserEventPayloadVariant239Previous.Enhanced => "enhanced",
                UserEventPayloadVariant239Previous.Standard => "standard",
                UserEventPayloadVariant239Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant239Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant239Previous.Elastic,
                "enhanced" => UserEventPayloadVariant239Previous.Enhanced,
                "standard" => UserEventPayloadVariant239Previous.Standard,
                "turbo" => UserEventPayloadVariant239Previous.Turbo,
                _ => null,
            };
        }
    }
}