
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1ed2975831fbb888CrsPhpAction
    {
        /// <summary>
        ///
        /// </summary>
        Deny,
        /// <summary>
        ///
        /// </summary>
        Log,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared1ed2975831fbb888CrsPhpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1ed2975831fbb888CrsPhpAction value)
        {
            return value switch
            {
                AutoSDKShared1ed2975831fbb888CrsPhpAction.Deny => "deny",
                AutoSDKShared1ed2975831fbb888CrsPhpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1ed2975831fbb888CrsPhpAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShared1ed2975831fbb888CrsPhpAction.Deny,
                "log" => AutoSDKShared1ed2975831fbb888CrsPhpAction.Log,
                _ => null,
            };
        }
    }
}