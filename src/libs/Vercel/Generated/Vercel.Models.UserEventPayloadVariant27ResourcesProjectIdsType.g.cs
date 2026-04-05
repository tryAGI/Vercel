
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant27ResourcesProjectIdsType
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant27ResourcesProjectIdsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant27ResourcesProjectIdsType value)
        {
            return value switch
            {
                UserEventPayloadVariant27ResourcesProjectIdsType.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant27ResourcesProjectIdsType? ToEnum(string value)
        {
            return value switch
            {
                "list" => UserEventPayloadVariant27ResourcesProjectIdsType.List,
                _ => null,
            };
        }
    }
}