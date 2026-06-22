
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2BindingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseServiceVariant2BindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2BindingFormat value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2BindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2BindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => CreateDeploymentResponseServiceVariant2BindingFormat.Url,
                _ => null,
            };
        }
    }
}