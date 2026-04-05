
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1FunctionsMaxDuration
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1FunctionsMaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1FunctionsMaxDuration value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1FunctionsMaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1FunctionsMaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => GetDeploymentResponseVariant1FunctionsMaxDuration.Max,
                _ => null,
            };
        }
    }
}