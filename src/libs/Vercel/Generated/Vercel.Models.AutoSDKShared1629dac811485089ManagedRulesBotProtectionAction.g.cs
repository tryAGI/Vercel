
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1629dac811485089ManagedRulesBotProtectionAction
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
    public static class AutoSDKShared1629dac811485089ManagedRulesBotProtectionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1629dac811485089ManagedRulesBotProtectionAction value)
        {
            return value switch
            {
                AutoSDKShared1629dac811485089ManagedRulesBotProtectionAction.Challenge => "challenge",
                AutoSDKShared1629dac811485089ManagedRulesBotProtectionAction.Deny => "deny",
                AutoSDKShared1629dac811485089ManagedRulesBotProtectionAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1629dac811485089ManagedRulesBotProtectionAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared1629dac811485089ManagedRulesBotProtectionAction.Challenge,
                "deny" => AutoSDKShared1629dac811485089ManagedRulesBotProtectionAction.Deny,
                "log" => AutoSDKShared1629dac811485089ManagedRulesBotProtectionAction.Log,
                _ => null,
            };
        }
    }
}