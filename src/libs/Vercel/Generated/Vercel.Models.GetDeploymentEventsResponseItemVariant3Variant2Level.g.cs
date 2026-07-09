
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseItemVariant3Variant2Level
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
    public static class GetDeploymentEventsResponseItemVariant3Variant2LevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseItemVariant3Variant2Level value)
        {
            return value switch
            {
                GetDeploymentEventsResponseItemVariant3Variant2Level.Error => "error",
                GetDeploymentEventsResponseItemVariant3Variant2Level.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseItemVariant3Variant2Level? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetDeploymentEventsResponseItemVariant3Variant2Level.Error,
                "warning" => GetDeploymentEventsResponseItemVariant3Variant2Level.Warning,
                _ => null,
            };
        }
    }
}