
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunVariant2SourceVariant2Origin
    {
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDeploymentCheckRunsResponseRunVariant2SourceVariant2OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunVariant2SourceVariant2Origin value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunVariant2SourceVariant2Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunVariant2SourceVariant2Origin? ToEnum(string value)
        {
            return value switch
            {
                "platform" => ListDeploymentCheckRunsResponseRunVariant2SourceVariant2Origin.Platform,
                _ => null,
            };
        }
    }
}