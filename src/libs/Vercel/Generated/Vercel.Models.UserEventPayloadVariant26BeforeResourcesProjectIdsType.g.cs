
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant26BeforeResourcesProjectIdsType
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant26BeforeResourcesProjectIdsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant26BeforeResourcesProjectIdsType value)
        {
            return value switch
            {
                UserEventPayloadVariant26BeforeResourcesProjectIdsType.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant26BeforeResourcesProjectIdsType? ToEnum(string value)
        {
            return value switch
            {
                "list" => UserEventPayloadVariant26BeforeResourcesProjectIdsType.List,
                _ => null,
            };
        }
    }
}