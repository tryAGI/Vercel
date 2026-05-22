
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant2SourceVariant1Origin
    {
        /// <summary>
        /// 
        /// </summary>
        Config,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentCheckRunResponseVariant2SourceVariant1OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant2SourceVariant1Origin value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant2SourceVariant1Origin.Config => "config",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant2SourceVariant1Origin? ToEnum(string value)
        {
            return value switch
            {
                "config" => GetDeploymentCheckRunResponseVariant2SourceVariant1Origin.Config,
                _ => null,
            };
        }
    }
}