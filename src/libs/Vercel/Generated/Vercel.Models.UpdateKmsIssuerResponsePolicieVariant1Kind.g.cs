
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateKmsIssuerResponsePolicieVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateKmsIssuerResponsePolicieVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKmsIssuerResponsePolicieVariant1Kind value)
        {
            return value switch
            {
                UpdateKmsIssuerResponsePolicieVariant1Kind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKmsIssuerResponsePolicieVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => UpdateKmsIssuerResponsePolicieVariant1Kind.ProjectGrant,
                _ => null,
            };
        }
    }
}