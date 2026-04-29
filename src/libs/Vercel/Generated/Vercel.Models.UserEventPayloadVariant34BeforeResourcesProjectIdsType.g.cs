
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant34BeforeResourcesProjectIdsType
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant34BeforeResourcesProjectIdsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant34BeforeResourcesProjectIdsType value)
        {
            return value switch
            {
                UserEventPayloadVariant34BeforeResourcesProjectIdsType.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant34BeforeResourcesProjectIdsType? ToEnum(string value)
        {
            return value switch
            {
                "list" => UserEventPayloadVariant34BeforeResourcesProjectIdsType.List,
                _ => null,
            };
        }
    }
}