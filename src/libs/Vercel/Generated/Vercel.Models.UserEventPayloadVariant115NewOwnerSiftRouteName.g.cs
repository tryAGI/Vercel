
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerSiftRouteName
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant115NewOwnerSiftRouteNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerSiftRouteName value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerSiftRouteName.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerSiftRouteName? ToEnum(string value)
        {
            return value switch
            {
                "string" => UserEventPayloadVariant115NewOwnerSiftRouteName.String,
                _ => null,
            };
        }
    }
}