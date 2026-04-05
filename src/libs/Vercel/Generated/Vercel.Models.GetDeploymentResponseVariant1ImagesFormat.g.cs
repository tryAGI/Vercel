
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ImagesFormat
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
    public static class GetDeploymentResponseVariant1ImagesFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ImagesFormat value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ImagesFormat.ImageAvif => "image/avif",
                GetDeploymentResponseVariant1ImagesFormat.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ImagesFormat? ToEnum(string value)
        {
            return value switch
            {
                "image/avif" => GetDeploymentResponseVariant1ImagesFormat.ImageAvif,
                "image/webp" => GetDeploymentResponseVariant1ImagesFormat.ImageWebp,
                _ => null,
            };
        }
    }
}