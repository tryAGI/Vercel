
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8dbad85779e5c1fbMitigateAction
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
    public static class AutoSDKShared8dbad85779e5c1fbMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8dbad85779e5c1fbMitigateAction value)
        {
            return value switch
            {
                AutoSDKShared8dbad85779e5c1fbMitigateAction.Challenge => "challenge",
                AutoSDKShared8dbad85779e5c1fbMitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8dbad85779e5c1fbMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared8dbad85779e5c1fbMitigateAction.Challenge,
                "deny" => AutoSDKShared8dbad85779e5c1fbMitigateAction.Deny,
                _ => null,
            };
        }
    }
}