
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBotsAction
    {
        /// <summary>
        ///
        /// </summary>
        Challenge,
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
    public static class AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBotsAction value)
        {
            return value switch
            {
                AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBotsAction.Challenge => "challenge",
                AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBotsAction.Deny => "deny",
                AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBotsAction.Challenge,
                "deny" => AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBotsAction.Deny,
                "log" => AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}