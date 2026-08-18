
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateKmsIssuerResponsePolicieVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKmsIssuerResponsePolicieVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKmsIssuerResponsePolicieVariant1Kind value)
        {
            return value switch
            {
                CreateKmsIssuerResponsePolicieVariant1Kind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKmsIssuerResponsePolicieVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => CreateKmsIssuerResponsePolicieVariant1Kind.ProjectGrant,
                _ => null,
            };
        }
    }
}