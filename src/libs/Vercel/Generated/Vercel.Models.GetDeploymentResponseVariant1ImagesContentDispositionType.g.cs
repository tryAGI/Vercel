
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ImagesContentDispositionType
    {
        /// <summary>
        /// 
        /// </summary>
        Attachment,
        /// <summary>
        /// 
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ImagesContentDispositionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ImagesContentDispositionType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ImagesContentDispositionType.Attachment => "attachment",
                GetDeploymentResponseVariant1ImagesContentDispositionType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ImagesContentDispositionType? ToEnum(string value)
        {
            return value switch
            {
                "attachment" => GetDeploymentResponseVariant1ImagesContentDispositionType.Attachment,
                "inline" => GetDeploymentResponseVariant1ImagesContentDispositionType.Inline,
                _ => null,
            };
        }
    }
}