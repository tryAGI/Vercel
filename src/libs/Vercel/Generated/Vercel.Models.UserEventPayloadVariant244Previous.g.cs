
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant244Previous
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
    public static class UserEventPayloadVariant244PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant244Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant244Previous.Elastic => "elastic",
                UserEventPayloadVariant244Previous.Enhanced => "enhanced",
                UserEventPayloadVariant244Previous.Standard => "standard",
                UserEventPayloadVariant244Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant244Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant244Previous.Elastic,
                "enhanced" => UserEventPayloadVariant244Previous.Enhanced,
                "standard" => UserEventPayloadVariant244Previous.Standard,
                "turbo" => UserEventPayloadVariant244Previous.Turbo,
                _ => null,
            };
        }
    }
}