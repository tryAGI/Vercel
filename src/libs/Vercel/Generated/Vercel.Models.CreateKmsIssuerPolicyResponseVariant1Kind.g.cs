
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateKmsIssuerPolicyResponseVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKmsIssuerPolicyResponseVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKmsIssuerPolicyResponseVariant1Kind value)
        {
            return value switch
            {
                CreateKmsIssuerPolicyResponseVariant1Kind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKmsIssuerPolicyResponseVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => CreateKmsIssuerPolicyResponseVariant1Kind.ProjectGrant,
                _ => null,
            };
        }
    }
}