
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant34AfterResourcesProjectIdsItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant34AfterResourcesProjectIdsItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant34AfterResourcesProjectIdsItemsType value)
        {
            return value switch
            {
                UserEventPayloadVariant34AfterResourcesProjectIdsItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant34AfterResourcesProjectIdsItemsType? ToEnum(string value)
        {
            return value switch
            {
                "string" => UserEventPayloadVariant34AfterResourcesProjectIdsItemsType.String,
                _ => null,
            };
        }
    }
}