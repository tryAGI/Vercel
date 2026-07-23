
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2ImagesFormat
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
    public static class GetDeploymentResponseVariant2ImagesFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ImagesFormat value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ImagesFormat.ImageAvif => "image/avif",
                GetDeploymentResponseVariant2ImagesFormat.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ImagesFormat? ToEnum(string value)
        {
            return value switch
            {
                "image/avif" => GetDeploymentResponseVariant2ImagesFormat.ImageAvif,
                "image/webp" => GetDeploymentResponseVariant2ImagesFormat.ImageWebp,
                _ => null,
            };
        }
    }
}