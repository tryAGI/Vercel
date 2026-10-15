
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareded558c13e366df17CrsGenAction
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
    public static class AutoSDKShareded558c13e366df17CrsGenActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareded558c13e366df17CrsGenAction value)
        {
            return value switch
            {
                AutoSDKShareded558c13e366df17CrsGenAction.Deny => "deny",
                AutoSDKShareded558c13e366df17CrsGenAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareded558c13e366df17CrsGenAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShareded558c13e366df17CrsGenAction.Deny,
                "log" => AutoSDKShareded558c13e366df17CrsGenAction.Log,
                _ => null,
            };
        }
    }
}