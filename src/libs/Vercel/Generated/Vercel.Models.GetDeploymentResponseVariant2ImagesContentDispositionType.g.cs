
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2ImagesContentDispositionType
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
    public static class GetDeploymentResponseVariant2ImagesContentDispositionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ImagesContentDispositionType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ImagesContentDispositionType.Attachment => "attachment",
                GetDeploymentResponseVariant2ImagesContentDispositionType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ImagesContentDispositionType? ToEnum(string value)
        {
            return value switch
            {
                "attachment" => GetDeploymentResponseVariant2ImagesContentDispositionType.Attachment,
                "inline" => GetDeploymentResponseVariant2ImagesContentDispositionType.Inline,
                _ => null,
            };
        }
    }
}