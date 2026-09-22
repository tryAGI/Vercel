
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3770e4df73b880dManagedRulesTrafficSourcesAction
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
    public static class AutoSDKShareda3770e4df73b880dManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3770e4df73b880dManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                AutoSDKShareda3770e4df73b880dManagedRulesTrafficSourcesAction.Challenge => "challenge",
                AutoSDKShareda3770e4df73b880dManagedRulesTrafficSourcesAction.Deny => "deny",
                AutoSDKShareda3770e4df73b880dManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3770e4df73b880dManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShareda3770e4df73b880dManagedRulesTrafficSourcesAction.Challenge,
                "deny" => AutoSDKShareda3770e4df73b880dManagedRulesTrafficSourcesAction.Deny,
                "log" => AutoSDKShareda3770e4df73b880dManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}