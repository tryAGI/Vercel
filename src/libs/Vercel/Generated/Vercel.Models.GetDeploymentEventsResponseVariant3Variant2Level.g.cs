
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentEventsResponseVariant3Variant2Level
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentEventsResponseVariant3Variant2LevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseVariant3Variant2Level value)
        {
            return value switch
            {
                GetDeploymentEventsResponseVariant3Variant2Level.Error => "error",
                GetDeploymentEventsResponseVariant3Variant2Level.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseVariant3Variant2Level? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetDeploymentEventsResponseVariant3Variant2Level.Error,
                "warning" => GetDeploymentEventsResponseVariant3Variant2Level.Warning,
                _ => null,
            };
        }
    }
}