
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb4cb9cbf2561e851CrsSdAction
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
    public static class AutoSDKSharedb4cb9cbf2561e851CrsSdActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb4cb9cbf2561e851CrsSdAction value)
        {
            return value switch
            {
                AutoSDKSharedb4cb9cbf2561e851CrsSdAction.Deny => "deny",
                AutoSDKSharedb4cb9cbf2561e851CrsSdAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb4cb9cbf2561e851CrsSdAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKSharedb4cb9cbf2561e851CrsSdAction.Deny,
                "log" => AutoSDKSharedb4cb9cbf2561e851CrsSdAction.Log,
                _ => null,
            };
        }
    }
}