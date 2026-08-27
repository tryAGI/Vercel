
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The issuer policy kind.
    /// </summary>
    public enum UpdateKmsIssuerPolicyKind
    {
        /// <summary>
        ///
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateKmsIssuerPolicyKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKmsIssuerPolicyKind value)
        {
            return value switch
            {
                UpdateKmsIssuerPolicyKind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKmsIssuerPolicyKind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => UpdateKmsIssuerPolicyKind.ProjectGrant,
                _ => null,
            };
        }
    }
}