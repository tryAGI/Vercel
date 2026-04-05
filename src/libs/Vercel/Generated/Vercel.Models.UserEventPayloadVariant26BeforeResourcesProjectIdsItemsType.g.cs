
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant26BeforeResourcesProjectIdsItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant26BeforeResourcesProjectIdsItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant26BeforeResourcesProjectIdsItemsType value)
        {
            return value switch
            {
                UserEventPayloadVariant26BeforeResourcesProjectIdsItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant26BeforeResourcesProjectIdsItemsType? ToEnum(string value)
        {
            return value switch
            {
                "string" => UserEventPayloadVariant26BeforeResourcesProjectIdsItemsType.String,
                _ => null,
            };
        }
    }
}