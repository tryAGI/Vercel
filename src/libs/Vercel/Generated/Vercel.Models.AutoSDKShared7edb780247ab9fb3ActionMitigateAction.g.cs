
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7edb780247ab9fb3ActionMitigateAction
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Bypass,
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
        /// <summary>
        ///
        /// </summary>
        RateLimit,
        /// <summary>
        ///
        /// </summary>
        Redirect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7edb780247ab9fb3ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7edb780247ab9fb3ActionMitigateAction value)
        {
            return value switch
            {
                AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Allow => "allow",
                AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Bypass => "bypass",
                AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Challenge => "challenge",
                AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Deny => "deny",
                AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Log => "log",
                AutoSDKShared7edb780247ab9fb3ActionMitigateAction.RateLimit => "rate_limit",
                AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7edb780247ab9fb3ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Allow,
                "bypass" => AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Bypass,
                "challenge" => AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Challenge,
                "deny" => AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Deny,
                "log" => AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Log,
                "rate_limit" => AutoSDKShared7edb780247ab9fb3ActionMitigateAction.RateLimit,
                "redirect" => AutoSDKShared7edb780247ab9fb3ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}