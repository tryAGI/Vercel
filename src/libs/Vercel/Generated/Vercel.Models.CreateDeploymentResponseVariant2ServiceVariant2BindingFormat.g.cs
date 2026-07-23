
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant2BindingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ServiceVariant2BindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant2BindingFormat value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant2BindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant2BindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => CreateDeploymentResponseVariant2ServiceVariant2BindingFormat.Url,
                _ => null,
            };
        }
    }
}