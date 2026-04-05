
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerSiftRouteName
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant114NewOwnerSiftRouteNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerSiftRouteName value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerSiftRouteName.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerSiftRouteName? ToEnum(string value)
        {
            return value switch
            {
                "string" => UserEventPayloadVariant114NewOwnerSiftRouteName.String,
                _ => null,
            };
        }
    }
}