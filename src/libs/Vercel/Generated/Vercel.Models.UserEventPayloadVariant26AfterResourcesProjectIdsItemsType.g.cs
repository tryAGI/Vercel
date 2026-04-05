
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant26AfterResourcesProjectIdsItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant26AfterResourcesProjectIdsItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant26AfterResourcesProjectIdsItemsType value)
        {
            return value switch
            {
                UserEventPayloadVariant26AfterResourcesProjectIdsItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant26AfterResourcesProjectIdsItemsType? ToEnum(string value)
        {
            return value switch
            {
                "string" => UserEventPayloadVariant26AfterResourcesProjectIdsItemsType.String,
                _ => null,
            };
        }
    }
}