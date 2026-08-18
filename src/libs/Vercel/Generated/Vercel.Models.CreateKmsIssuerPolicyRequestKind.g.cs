
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateKmsIssuerPolicyRequestKind
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKmsIssuerPolicyRequestKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKmsIssuerPolicyRequestKind value)
        {
            return value switch
            {
                CreateKmsIssuerPolicyRequestKind.ProjectGrant => "project-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKmsIssuerPolicyRequestKind? ToEnum(string value)
        {
            return value switch
            {
                "project-grant" => CreateKmsIssuerPolicyRequestKind.ProjectGrant,
                _ => null,
            };
        }
    }
}