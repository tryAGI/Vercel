
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared02b3ab4a1bf599afPolicieVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared02b3ab4a1bf599afPolicieVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared02b3ab4a1bf599afPolicieVariant1Kind value)
        {
            return value switch
            {
                AutoSDKShared02b3ab4a1bf599afPolicieVariant1Kind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared02b3ab4a1bf599afPolicieVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => AutoSDKShared02b3ab4a1bf599afPolicieVariant1Kind.ProjectGrant,
                _ => null,
            };
        }
    }
}