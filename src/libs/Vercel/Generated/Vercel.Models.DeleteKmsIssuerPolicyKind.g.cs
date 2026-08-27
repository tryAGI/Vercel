
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The issuer policy kind.
    /// </summary>
    public enum DeleteKmsIssuerPolicyKind
    {
        /// <summary>
        ///
        /// </summary>
        ConnexGrant,
        /// <summary>
        ///
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteKmsIssuerPolicyKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteKmsIssuerPolicyKind value)
        {
            return value switch
            {
                DeleteKmsIssuerPolicyKind.ConnexGrant => "connex-grant",
                DeleteKmsIssuerPolicyKind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteKmsIssuerPolicyKind? ToEnum(string value)
        {
            return value switch
            {
                "connex-grant" => DeleteKmsIssuerPolicyKind.ConnexGrant,
                "project-grant" => DeleteKmsIssuerPolicyKind.ProjectGrant,
                _ => null,
            };
        }
    }
}