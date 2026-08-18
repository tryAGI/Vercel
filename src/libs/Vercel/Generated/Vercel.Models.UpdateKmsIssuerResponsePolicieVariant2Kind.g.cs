
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateKmsIssuerResponsePolicieVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        ConnexGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateKmsIssuerResponsePolicieVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKmsIssuerResponsePolicieVariant2Kind value)
        {
            return value switch
            {
                UpdateKmsIssuerResponsePolicieVariant2Kind.ConnexGrant => "connex-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKmsIssuerResponsePolicieVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "connex-grant" => UpdateKmsIssuerResponsePolicieVariant2Kind.ConnexGrant,
                _ => null,
            };
        }
    }
}