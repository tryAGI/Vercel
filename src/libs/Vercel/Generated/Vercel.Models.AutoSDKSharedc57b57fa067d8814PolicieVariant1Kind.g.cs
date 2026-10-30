
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc57b57fa067d8814PolicieVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc57b57fa067d8814PolicieVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc57b57fa067d8814PolicieVariant1Kind value)
        {
            return value switch
            {
                AutoSDKSharedc57b57fa067d8814PolicieVariant1Kind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc57b57fa067d8814PolicieVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => AutoSDKSharedc57b57fa067d8814PolicieVariant1Kind.ProjectGrant,
                _ => null,
            };
        }
    }
}