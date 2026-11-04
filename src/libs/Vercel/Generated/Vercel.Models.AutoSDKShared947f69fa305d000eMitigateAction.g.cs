
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared947f69fa305d000eMitigateAction
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
    public static class AutoSDKShared947f69fa305d000eMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared947f69fa305d000eMitigateAction value)
        {
            return value switch
            {
                AutoSDKShared947f69fa305d000eMitigateAction.Challenge => "challenge",
                AutoSDKShared947f69fa305d000eMitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared947f69fa305d000eMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared947f69fa305d000eMitigateAction.Challenge,
                "deny" => AutoSDKShared947f69fa305d000eMitigateAction.Deny,
                _ => null,
            };
        }
    }
}