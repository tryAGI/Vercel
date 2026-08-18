
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RevokeKmsSigningKeyResponseOrigin
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
    public static class RevokeKmsSigningKeyResponseOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RevokeKmsSigningKeyResponseOrigin value)
        {
            return value switch
            {
                RevokeKmsSigningKeyResponseOrigin.External => "external",
                RevokeKmsSigningKeyResponseOrigin.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RevokeKmsSigningKeyResponseOrigin? ToEnum(string value)
        {
            return value switch
            {
                "external" => RevokeKmsSigningKeyResponseOrigin.External,
                "vercel" => RevokeKmsSigningKeyResponseOrigin.Vercel,
                _ => null,
            };
        }
    }
}