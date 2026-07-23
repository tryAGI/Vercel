
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2ImagesFormat
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
    public static class CreateDeploymentResponseVariant2ImagesFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ImagesFormat value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ImagesFormat.ImageAvif => "image/avif",
                CreateDeploymentResponseVariant2ImagesFormat.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ImagesFormat? ToEnum(string value)
        {
            return value switch
            {
                "image/avif" => CreateDeploymentResponseVariant2ImagesFormat.ImageAvif,
                "image/webp" => CreateDeploymentResponseVariant2ImagesFormat.ImageWebp,
                _ => null,
            };
        }
    }
}