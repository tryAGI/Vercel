
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseItemVariant2Level
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
    public static class GetDeploymentEventsResponseItemVariant2LevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseItemVariant2Level value)
        {
            return value switch
            {
                GetDeploymentEventsResponseItemVariant2Level.Error => "error",
                GetDeploymentEventsResponseItemVariant2Level.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseItemVariant2Level? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetDeploymentEventsResponseItemVariant2Level.Error,
                "warning" => GetDeploymentEventsResponseItemVariant2Level.Warning,
                _ => null,
            };
        }
    }
}