
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant26AfterResourcesProjectIdsType
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant26AfterResourcesProjectIdsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant26AfterResourcesProjectIdsType value)
        {
            return value switch
            {
                UserEventPayloadVariant26AfterResourcesProjectIdsType.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant26AfterResourcesProjectIdsType? ToEnum(string value)
        {
            return value switch
            {
                "list" => UserEventPayloadVariant26AfterResourcesProjectIdsType.List,
                _ => null,
            };
        }
    }
}