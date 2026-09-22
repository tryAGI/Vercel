
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5f73cd821829ef28MitigateAction
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
    public static class AutoSDKShared5f73cd821829ef28MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5f73cd821829ef28MitigateAction value)
        {
            return value switch
            {
                AutoSDKShared5f73cd821829ef28MitigateAction.Challenge => "challenge",
                AutoSDKShared5f73cd821829ef28MitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5f73cd821829ef28MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared5f73cd821829ef28MitigateAction.Challenge,
                "deny" => AutoSDKShared5f73cd821829ef28MitigateAction.Deny,
                _ => null,
            };
        }
    }
}