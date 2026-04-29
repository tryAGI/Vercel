
#nullable enable

namespace Vercel
{
    /// <summary>
    /// optional since entries prior to 2026-04-23 do not contain this field
    /// </summary>
    public enum UserEventPayloadVariant315TokenPrefix
    {
        /// <summary>
        /// 
        /// </summary>
        Vca,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant315TokenPrefixExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant315TokenPrefix value)
        {
            return value switch
            {
                UserEventPayloadVariant315TokenPrefix.Vca => "vca_",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant315TokenPrefix? ToEnum(string value)
        {
            return value switch
            {
                "vca_" => UserEventPayloadVariant315TokenPrefix.Vca,
                _ => null,
            };
        }
    }
}