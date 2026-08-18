
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateKmsIssuerPolicyResponseVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        ConnexGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateKmsIssuerPolicyResponseVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKmsIssuerPolicyResponseVariant2Kind value)
        {
            return value switch
            {
                UpdateKmsIssuerPolicyResponseVariant2Kind.ConnexGrant => "connex-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKmsIssuerPolicyResponseVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "connex-grant" => UpdateKmsIssuerPolicyResponseVariant2Kind.ConnexGrant,
                _ => null,
            };
        }
    }
}