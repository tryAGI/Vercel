
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant1SourceVariant5SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelCiCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentCheckRunResponseVariant1SourceVariant5SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant1SourceVariant5SubKind value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant1SourceVariant5SubKind.VercelCiCheck => "vercel-ci-check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant1SourceVariant5SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-ci-check" => GetDeploymentCheckRunResponseVariant1SourceVariant5SubKind.VercelCiCheck,
                _ => null,
            };
        }
    }
}