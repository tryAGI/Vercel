
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPrincipalVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPrincipalVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPrincipalVariant2Type value)
        {
            return value switch
            {
                UserEventPrincipalVariant2Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPrincipalVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPrincipalVariant2Type.App,
                _ => null,
            };
        }
    }
}