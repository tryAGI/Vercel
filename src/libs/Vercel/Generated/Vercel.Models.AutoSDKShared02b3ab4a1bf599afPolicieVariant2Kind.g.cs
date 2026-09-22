
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared02b3ab4a1bf599afPolicieVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        ConnexGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared02b3ab4a1bf599afPolicieVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared02b3ab4a1bf599afPolicieVariant2Kind value)
        {
            return value switch
            {
                AutoSDKShared02b3ab4a1bf599afPolicieVariant2Kind.ConnexGrant => "connex-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared02b3ab4a1bf599afPolicieVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "connex-grant" => AutoSDKShared02b3ab4a1bf599afPolicieVariant2Kind.ConnexGrant,
                _ => null,
            };
        }
    }
}