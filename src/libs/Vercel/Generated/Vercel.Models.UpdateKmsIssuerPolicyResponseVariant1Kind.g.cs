
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateKmsIssuerPolicyResponseVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateKmsIssuerPolicyResponseVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKmsIssuerPolicyResponseVariant1Kind value)
        {
            return value switch
            {
                UpdateKmsIssuerPolicyResponseVariant1Kind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKmsIssuerPolicyResponseVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => UpdateKmsIssuerPolicyResponseVariant1Kind.ProjectGrant,
                _ => null,
            };
        }
    }
}