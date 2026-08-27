
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant2SourceVariant1SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelCi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentCheckRunResponseVariant2SourceVariant1SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant2SourceVariant1SubKind value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant2SourceVariant1SubKind.VercelCi => "vercel-ci",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant2SourceVariant1SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-ci" => GetDeploymentCheckRunResponseVariant2SourceVariant1SubKind.VercelCi,
                _ => null,
            };
        }
    }
}