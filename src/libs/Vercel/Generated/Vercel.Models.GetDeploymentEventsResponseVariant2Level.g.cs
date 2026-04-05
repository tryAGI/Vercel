
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseVariant2Level
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
    public static class GetDeploymentEventsResponseVariant2LevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseVariant2Level value)
        {
            return value switch
            {
                GetDeploymentEventsResponseVariant2Level.Error => "error",
                GetDeploymentEventsResponseVariant2Level.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseVariant2Level? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetDeploymentEventsResponseVariant2Level.Error,
                "warning" => GetDeploymentEventsResponseVariant2Level.Warning,
                _ => null,
            };
        }
    }
}