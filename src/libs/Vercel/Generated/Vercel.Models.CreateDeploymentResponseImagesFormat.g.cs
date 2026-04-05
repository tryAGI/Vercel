
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseImagesFormat
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
    public static class CreateDeploymentResponseImagesFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseImagesFormat value)
        {
            return value switch
            {
                CreateDeploymentResponseImagesFormat.ImageAvif => "image/avif",
                CreateDeploymentResponseImagesFormat.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseImagesFormat? ToEnum(string value)
        {
            return value switch
            {
                "image/avif" => CreateDeploymentResponseImagesFormat.ImageAvif,
                "image/webp" => CreateDeploymentResponseImagesFormat.ImageWebp,
                _ => null,
            };
        }
    }
}