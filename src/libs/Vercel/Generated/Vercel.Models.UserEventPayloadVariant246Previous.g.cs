
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant246Previous
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
    public static class UserEventPayloadVariant246PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant246Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant246Previous.Elastic => "elastic",
                UserEventPayloadVariant246Previous.Enhanced => "enhanced",
                UserEventPayloadVariant246Previous.Standard => "standard",
                UserEventPayloadVariant246Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant246Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant246Previous.Elastic,
                "enhanced" => UserEventPayloadVariant246Previous.Enhanced,
                "standard" => UserEventPayloadVariant246Previous.Standard,
                "turbo" => UserEventPayloadVariant246Previous.Turbo,
                _ => null,
            };
        }
    }
}