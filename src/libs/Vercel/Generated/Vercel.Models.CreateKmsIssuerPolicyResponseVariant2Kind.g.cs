
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateKmsIssuerPolicyResponseVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        ConnexGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKmsIssuerPolicyResponseVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKmsIssuerPolicyResponseVariant2Kind value)
        {
            return value switch
            {
                CreateKmsIssuerPolicyResponseVariant2Kind.ConnexGrant => "connex-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKmsIssuerPolicyResponseVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "connex-grant" => CreateKmsIssuerPolicyResponseVariant2Kind.ConnexGrant,
                _ => null,
            };
        }
    }
}