
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetKmsIssuerResponsePolicieVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKmsIssuerResponsePolicieVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKmsIssuerResponsePolicieVariant1Kind value)
        {
            return value switch
            {
                GetKmsIssuerResponsePolicieVariant1Kind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKmsIssuerResponsePolicieVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => GetKmsIssuerResponsePolicieVariant1Kind.ProjectGrant,
                _ => null,
            };
        }
    }
}