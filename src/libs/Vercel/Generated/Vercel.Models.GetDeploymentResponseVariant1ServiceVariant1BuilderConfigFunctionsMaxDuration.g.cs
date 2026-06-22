
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ServiceVariant1BuilderConfigFunctionsMaxDuration
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ServiceVariant1BuilderConfigFunctionsMaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ServiceVariant1BuilderConfigFunctionsMaxDuration value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ServiceVariant1BuilderConfigFunctionsMaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ServiceVariant1BuilderConfigFunctionsMaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => GetDeploymentResponseVariant1ServiceVariant1BuilderConfigFunctionsMaxDuration.Max,
                _ => null,
            };
        }
    }
}