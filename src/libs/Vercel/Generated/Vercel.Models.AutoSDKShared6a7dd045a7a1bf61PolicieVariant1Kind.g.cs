
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6a7dd045a7a1bf61PolicieVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind value)
        {
            return value switch
            {
                AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind.ProjectGrant,
                _ => null,
            };
        }
    }
}