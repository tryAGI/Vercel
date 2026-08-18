
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKmsIssuerResponsePolicieVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        ConnexGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKmsIssuerResponsePolicieVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKmsIssuerResponsePolicieVariant2Kind value)
        {
            return value switch
            {
                GetKmsIssuerResponsePolicieVariant2Kind.ConnexGrant => "connex-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKmsIssuerResponsePolicieVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "connex-grant" => GetKmsIssuerResponsePolicieVariant2Kind.ConnexGrant,
                _ => null,
            };
        }
    }
}