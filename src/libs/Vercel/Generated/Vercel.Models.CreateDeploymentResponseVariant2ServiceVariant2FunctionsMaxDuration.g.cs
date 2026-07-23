
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant2FunctionsMaxDuration
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ServiceVariant2FunctionsMaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant2FunctionsMaxDuration value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant2FunctionsMaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant2FunctionsMaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => CreateDeploymentResponseVariant2ServiceVariant2FunctionsMaxDuration.Max,
                _ => null,
            };
        }
    }
}