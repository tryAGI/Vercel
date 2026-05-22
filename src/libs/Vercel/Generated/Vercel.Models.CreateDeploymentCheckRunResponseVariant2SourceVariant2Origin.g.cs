
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant2SourceVariant2Origin
    {
        /// <summary>
        /// 
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentCheckRunResponseVariant2SourceVariant2OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant2SourceVariant2Origin value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant2SourceVariant2Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant2SourceVariant2Origin? ToEnum(string value)
        {
            return value switch
            {
                "platform" => CreateDeploymentCheckRunResponseVariant2SourceVariant2Origin.Platform,
                _ => null,
            };
        }
    }
}