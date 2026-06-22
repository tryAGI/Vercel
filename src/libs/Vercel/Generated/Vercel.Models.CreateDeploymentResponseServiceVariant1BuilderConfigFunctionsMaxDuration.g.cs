
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDuration
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDuration value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDuration.Max,
                _ => null,
            };
        }
    }
}