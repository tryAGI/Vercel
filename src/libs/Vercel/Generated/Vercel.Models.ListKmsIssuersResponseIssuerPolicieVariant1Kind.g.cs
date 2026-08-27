
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListKmsIssuersResponseIssuerPolicieVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListKmsIssuersResponseIssuerPolicieVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListKmsIssuersResponseIssuerPolicieVariant1Kind value)
        {
            return value switch
            {
                ListKmsIssuersResponseIssuerPolicieVariant1Kind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListKmsIssuersResponseIssuerPolicieVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => ListKmsIssuersResponseIssuerPolicieVariant1Kind.ProjectGrant,
                _ => null,
            };
        }
    }
}