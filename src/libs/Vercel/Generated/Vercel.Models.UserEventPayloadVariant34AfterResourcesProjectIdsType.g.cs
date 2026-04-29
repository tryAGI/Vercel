
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant34AfterResourcesProjectIdsType
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant34AfterResourcesProjectIdsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant34AfterResourcesProjectIdsType value)
        {
            return value switch
            {
                UserEventPayloadVariant34AfterResourcesProjectIdsType.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant34AfterResourcesProjectIdsType? ToEnum(string value)
        {
            return value switch
            {
                "list" => UserEventPayloadVariant34AfterResourcesProjectIdsType.List,
                _ => null,
            };
        }
    }
}