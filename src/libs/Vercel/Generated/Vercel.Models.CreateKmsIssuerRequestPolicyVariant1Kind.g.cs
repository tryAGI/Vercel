
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateKmsIssuerRequestPolicyVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKmsIssuerRequestPolicyVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKmsIssuerRequestPolicyVariant1Kind value)
        {
            return value switch
            {
                CreateKmsIssuerRequestPolicyVariant1Kind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKmsIssuerRequestPolicyVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => CreateKmsIssuerRequestPolicyVariant1Kind.ProjectGrant,
                _ => null,
            };
        }
    }
}