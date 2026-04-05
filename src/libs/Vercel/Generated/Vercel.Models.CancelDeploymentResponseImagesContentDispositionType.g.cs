
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseImagesContentDispositionType
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
    public static class CancelDeploymentResponseImagesContentDispositionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseImagesContentDispositionType value)
        {
            return value switch
            {
                CancelDeploymentResponseImagesContentDispositionType.Attachment => "attachment",
                CancelDeploymentResponseImagesContentDispositionType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseImagesContentDispositionType? ToEnum(string value)
        {
            return value switch
            {
                "attachment" => CancelDeploymentResponseImagesContentDispositionType.Attachment,
                "inline" => CancelDeploymentResponseImagesContentDispositionType.Inline,
                _ => null,
            };
        }
    }
}