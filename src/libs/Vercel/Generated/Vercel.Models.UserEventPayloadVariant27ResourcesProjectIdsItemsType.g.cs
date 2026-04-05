
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant27ResourcesProjectIdsItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant27ResourcesProjectIdsItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant27ResourcesProjectIdsItemsType value)
        {
            return value switch
            {
                UserEventPayloadVariant27ResourcesProjectIdsItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant27ResourcesProjectIdsItemsType? ToEnum(string value)
        {
            return value switch
            {
                "string" => UserEventPayloadVariant27ResourcesProjectIdsItemsType.String,
                _ => null,
            };
        }
    }
}