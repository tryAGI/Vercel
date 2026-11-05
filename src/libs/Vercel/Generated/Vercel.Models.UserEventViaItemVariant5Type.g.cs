
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UserEventViaItemVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventViaItemVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventViaItemVariant5Type value)
        {
            return value switch
            {
                UserEventViaItemVariant5Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventViaItemVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UserEventViaItemVariant5Type.System,
                _ => null,
            };
        }
    }
}