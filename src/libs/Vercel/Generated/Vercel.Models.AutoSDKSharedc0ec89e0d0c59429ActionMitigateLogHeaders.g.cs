
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc0ec89e0d0c59429ActionMitigateLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc0ec89e0d0c59429ActionMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc0ec89e0d0c59429ActionMitigateLogHeaders value)
        {
            return value switch
            {
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc0ec89e0d0c59429ActionMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}