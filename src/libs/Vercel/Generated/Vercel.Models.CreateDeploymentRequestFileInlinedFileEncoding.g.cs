
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The file content encoding, it could be either a base64 (useful for images, etc.) of the files or the plain text for source code.
    /// </summary>
    public enum CreateDeploymentRequestFileInlinedFileEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Utf8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentRequestFileInlinedFileEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentRequestFileInlinedFileEncoding value)
        {
            return value switch
            {
                CreateDeploymentRequestFileInlinedFileEncoding.Base64 => "base64",
                CreateDeploymentRequestFileInlinedFileEncoding.Utf8 => "utf-8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentRequestFileInlinedFileEncoding? ToEnum(string value)
        {
            return value switch
            {
                "base64" => CreateDeploymentRequestFileInlinedFileEncoding.Base64,
                "utf-8" => CreateDeploymentRequestFileInlinedFileEncoding.Utf8,
                _ => null,
            };
        }
    }
}