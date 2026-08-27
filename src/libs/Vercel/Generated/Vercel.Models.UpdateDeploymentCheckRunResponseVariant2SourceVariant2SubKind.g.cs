
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseVariant2SourceVariant2SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelCiSentinel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeploymentCheckRunResponseVariant2SourceVariant2SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseVariant2SourceVariant2SubKind value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseVariant2SourceVariant2SubKind.VercelCiSentinel => "vercel-ci-sentinel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseVariant2SourceVariant2SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-ci-sentinel" => UpdateDeploymentCheckRunResponseVariant2SourceVariant2SubKind.VercelCiSentinel,
                _ => null,
            };
        }
    }
}