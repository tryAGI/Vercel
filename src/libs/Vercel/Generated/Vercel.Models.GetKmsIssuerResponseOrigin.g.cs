
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetKmsIssuerResponseOrigin
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
    public static class GetKmsIssuerResponseOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKmsIssuerResponseOrigin value)
        {
            return value switch
            {
                GetKmsIssuerResponseOrigin.External => "external",
                GetKmsIssuerResponseOrigin.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKmsIssuerResponseOrigin? ToEnum(string value)
        {
            return value switch
            {
                "external" => GetKmsIssuerResponseOrigin.External,
                "vercel" => GetKmsIssuerResponseOrigin.Vercel,
                _ => null,
            };
        }
    }
}