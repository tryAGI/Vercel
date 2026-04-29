
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant34BeforeResourcesProjectIdsItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant34BeforeResourcesProjectIdsItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant34BeforeResourcesProjectIdsItemsType value)
        {
            return value switch
            {
                UserEventPayloadVariant34BeforeResourcesProjectIdsItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant34BeforeResourcesProjectIdsItemsType? ToEnum(string value)
        {
            return value switch
            {
                "string" => UserEventPayloadVariant34BeforeResourcesProjectIdsItemsType.String,
                _ => null,
            };
        }
    }
}