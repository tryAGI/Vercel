
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedada259eacea6cff6MitigateAction
    {
        /// <summary>
        ///
        /// </summary>
        Challenge,
        /// <summary>
        ///
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedada259eacea6cff6MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedada259eacea6cff6MitigateAction value)
        {
            return value switch
            {
                AutoSDKSharedada259eacea6cff6MitigateAction.Challenge => "challenge",
                AutoSDKSharedada259eacea6cff6MitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedada259eacea6cff6MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedada259eacea6cff6MitigateAction.Challenge,
                "deny" => AutoSDKSharedada259eacea6cff6MitigateAction.Deny,
                _ => null,
            };
        }
    }
}