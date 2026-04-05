
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventViaItemVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventViaItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventViaItemVariant2Type value)
        {
            return value switch
            {
                UserEventViaItemVariant2Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventViaItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventViaItemVariant2Type.App,
                _ => null,
            };
        }
    }
}