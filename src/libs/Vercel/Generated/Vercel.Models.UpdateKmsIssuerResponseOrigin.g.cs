
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateKmsIssuerResponseOrigin
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
    public static class UpdateKmsIssuerResponseOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKmsIssuerResponseOrigin value)
        {
            return value switch
            {
                UpdateKmsIssuerResponseOrigin.External => "external",
                UpdateKmsIssuerResponseOrigin.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKmsIssuerResponseOrigin? ToEnum(string value)
        {
            return value switch
            {
                "external" => UpdateKmsIssuerResponseOrigin.External,
                "vercel" => UpdateKmsIssuerResponseOrigin.Vercel,
                _ => null,
            };
        }
    }
}