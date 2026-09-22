
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3770e4df73b880dManagedRulesOwaspAction
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
    public static class AutoSDKShareda3770e4df73b880dManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3770e4df73b880dManagedRulesOwaspAction value)
        {
            return value switch
            {
                AutoSDKShareda3770e4df73b880dManagedRulesOwaspAction.Challenge => "challenge",
                AutoSDKShareda3770e4df73b880dManagedRulesOwaspAction.Deny => "deny",
                AutoSDKShareda3770e4df73b880dManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3770e4df73b880dManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShareda3770e4df73b880dManagedRulesOwaspAction.Challenge,
                "deny" => AutoSDKShareda3770e4df73b880dManagedRulesOwaspAction.Deny,
                "log" => AutoSDKShareda3770e4df73b880dManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}