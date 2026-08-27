
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateKmsIssuerResponseOrigin
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
    public static class CreateKmsIssuerResponseOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKmsIssuerResponseOrigin value)
        {
            return value switch
            {
                CreateKmsIssuerResponseOrigin.External => "external",
                CreateKmsIssuerResponseOrigin.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKmsIssuerResponseOrigin? ToEnum(string value)
        {
            return value switch
            {
                "external" => CreateKmsIssuerResponseOrigin.External,
                "vercel" => CreateKmsIssuerResponseOrigin.Vercel,
                _ => null,
            };
        }
    }
}