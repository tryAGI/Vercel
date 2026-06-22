
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum GetDeploymentResponseVariant1ServiceVariant2BindingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ServiceVariant2BindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ServiceVariant2BindingFormat value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ServiceVariant2BindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ServiceVariant2BindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => GetDeploymentResponseVariant1ServiceVariant2BindingFormat.Url,
                _ => null,
            };
        }
    }
}