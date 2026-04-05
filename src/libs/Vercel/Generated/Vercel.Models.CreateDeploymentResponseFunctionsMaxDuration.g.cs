
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseFunctionsMaxDuration
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseFunctionsMaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseFunctionsMaxDuration value)
        {
            return value switch
            {
                CreateDeploymentResponseFunctionsMaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseFunctionsMaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => CreateDeploymentResponseFunctionsMaxDuration.Max,
                _ => null,
            };
        }
    }
}