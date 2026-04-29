
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerSiftRouteName
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant122NewOwnerSiftRouteNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerSiftRouteName value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerSiftRouteName.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerSiftRouteName? ToEnum(string value)
        {
            return value switch
            {
                "string" => UserEventPayloadVariant122NewOwnerSiftRouteName.String,
                _ => null,
            };
        }
    }
}