
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListKmsIssuersResponseIssuerOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListKmsIssuersResponseIssuerOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListKmsIssuersResponseIssuerOrigin value)
        {
            return value switch
            {
                ListKmsIssuersResponseIssuerOrigin.External => "external",
                ListKmsIssuersResponseIssuerOrigin.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListKmsIssuersResponseIssuerOrigin? ToEnum(string value)
        {
            return value switch
            {
                "external" => ListKmsIssuersResponseIssuerOrigin.External,
                "vercel" => ListKmsIssuersResponseIssuerOrigin.Vercel,
                _ => null,
            };
        }
    }
}