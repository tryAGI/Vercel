
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseImagesFormat
    {
        /// <summary>
        /// 
        /// </summary>
        ImageAvif,
        /// <summary>
        /// 
        /// </summary>
        ImageWebp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseImagesFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseImagesFormat value)
        {
            return value switch
            {
                CancelDeploymentResponseImagesFormat.ImageAvif => "image/avif",
                CancelDeploymentResponseImagesFormat.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseImagesFormat? ToEnum(string value)
        {
            return value switch
            {
                "image/avif" => CancelDeploymentResponseImagesFormat.ImageAvif,
                "image/webp" => CancelDeploymentResponseImagesFormat.ImageWebp,
                _ => null,
            };
        }
    }
}