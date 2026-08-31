
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant2ServiceVariant2FunctionsAffinityMode
    {
        /// <summary>
        ///
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2ServiceVariant2FunctionsAffinityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ServiceVariant2FunctionsAffinityMode value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ServiceVariant2FunctionsAffinityMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ServiceVariant2FunctionsAffinityMode? ToEnum(string value)
        {
            return value switch
            {
                "strict" => GetDeploymentResponseVariant2ServiceVariant2FunctionsAffinityMode.Strict,
                _ => null,
            };
        }
    }
}