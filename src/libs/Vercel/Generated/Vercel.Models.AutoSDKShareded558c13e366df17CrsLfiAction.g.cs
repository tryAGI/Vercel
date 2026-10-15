
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareded558c13e366df17CrsLfiAction
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
    public static class AutoSDKShareded558c13e366df17CrsLfiActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareded558c13e366df17CrsLfiAction value)
        {
            return value switch
            {
                AutoSDKShareded558c13e366df17CrsLfiAction.Deny => "deny",
                AutoSDKShareded558c13e366df17CrsLfiAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareded558c13e366df17CrsLfiAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShareded558c13e366df17CrsLfiAction.Deny,
                "log" => AutoSDKShareded558c13e366df17CrsLfiAction.Log,
                _ => null,
            };
        }
    }
}