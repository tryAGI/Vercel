
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb4cb9cbf2561e851CrsRfiAction
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
    public static class AutoSDKSharedb4cb9cbf2561e851CrsRfiActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb4cb9cbf2561e851CrsRfiAction value)
        {
            return value switch
            {
                AutoSDKSharedb4cb9cbf2561e851CrsRfiAction.Deny => "deny",
                AutoSDKSharedb4cb9cbf2561e851CrsRfiAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb4cb9cbf2561e851CrsRfiAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKSharedb4cb9cbf2561e851CrsRfiAction.Deny,
                "log" => AutoSDKSharedb4cb9cbf2561e851CrsRfiAction.Log,
                _ => null,
            };
        }
    }
}