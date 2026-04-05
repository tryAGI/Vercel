
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseImagesContentDispositionType
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
    public static class CreateDeploymentResponseImagesContentDispositionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseImagesContentDispositionType value)
        {
            return value switch
            {
                CreateDeploymentResponseImagesContentDispositionType.Attachment => "attachment",
                CreateDeploymentResponseImagesContentDispositionType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseImagesContentDispositionType? ToEnum(string value)
        {
            return value switch
            {
                "attachment" => CreateDeploymentResponseImagesContentDispositionType.Attachment,
                "inline" => CreateDeploymentResponseImagesContentDispositionType.Inline,
                _ => null,
            };
        }
    }
}