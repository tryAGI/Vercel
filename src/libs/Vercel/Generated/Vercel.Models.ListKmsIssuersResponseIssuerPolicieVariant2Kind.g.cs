
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListKmsIssuersResponseIssuerPolicieVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        ConnexGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListKmsIssuersResponseIssuerPolicieVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListKmsIssuersResponseIssuerPolicieVariant2Kind value)
        {
            return value switch
            {
                ListKmsIssuersResponseIssuerPolicieVariant2Kind.ConnexGrant => "connex-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListKmsIssuersResponseIssuerPolicieVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "connex-grant" => ListKmsIssuersResponseIssuerPolicieVariant2Kind.ConnexGrant,
                _ => null,
            };
        }
    }
}