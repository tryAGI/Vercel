
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDuration
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDuration value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDuration.Max,
                _ => null,
            };
        }
    }
}