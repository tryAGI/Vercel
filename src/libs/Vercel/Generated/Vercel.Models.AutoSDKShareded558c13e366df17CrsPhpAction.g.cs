
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareded558c13e366df17CrsPhpAction
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
    public static class AutoSDKShareded558c13e366df17CrsPhpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareded558c13e366df17CrsPhpAction value)
        {
            return value switch
            {
                AutoSDKShareded558c13e366df17CrsPhpAction.Deny => "deny",
                AutoSDKShareded558c13e366df17CrsPhpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareded558c13e366df17CrsPhpAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShareded558c13e366df17CrsPhpAction.Deny,
                "log" => AutoSDKShareded558c13e366df17CrsPhpAction.Log,
                _ => null,
            };
        }
    }
}