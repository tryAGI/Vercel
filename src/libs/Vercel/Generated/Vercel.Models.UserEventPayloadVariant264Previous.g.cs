
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant264Previous
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
    public static class UserEventPayloadVariant264PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant264Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant264Previous.Elastic => "elastic",
                UserEventPayloadVariant264Previous.Enhanced => "enhanced",
                UserEventPayloadVariant264Previous.Standard => "standard",
                UserEventPayloadVariant264Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant264Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant264Previous.Elastic,
                "enhanced" => UserEventPayloadVariant264Previous.Enhanced,
                "standard" => UserEventPayloadVariant264Previous.Standard,
                "turbo" => UserEventPayloadVariant264Previous.Turbo,
                _ => null,
            };
        }
    }
}