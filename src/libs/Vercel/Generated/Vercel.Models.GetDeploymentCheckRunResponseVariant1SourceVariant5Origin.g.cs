
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant1SourceVariant5Origin
    {
        /// <summary>
        ///
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentCheckRunResponseVariant1SourceVariant5OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant1SourceVariant5Origin value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant1SourceVariant5Origin.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant1SourceVariant5Origin? ToEnum(string value)
        {
            return value switch
            {
                "api" => GetDeploymentCheckRunResponseVariant1SourceVariant5Origin.Api,
                _ => null,
            };
        }
    }
}