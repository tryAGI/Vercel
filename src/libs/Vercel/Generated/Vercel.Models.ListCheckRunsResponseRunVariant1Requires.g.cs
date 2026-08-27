
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListCheckRunsResponseRunVariant1Requires
    {
        /// <summary>
        ///
        /// </summary>
        BuildReady,
        /// <summary>
        ///
        /// </summary>
        DeploymentUrl,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCheckRunsResponseRunVariant1RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant1Requires value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant1Requires.BuildReady => "build-ready",
                ListCheckRunsResponseRunVariant1Requires.DeploymentUrl => "deployment-url",
                ListCheckRunsResponseRunVariant1Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant1Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => ListCheckRunsResponseRunVariant1Requires.BuildReady,
                "deployment-url" => ListCheckRunsResponseRunVariant1Requires.DeploymentUrl,
                "none" => ListCheckRunsResponseRunVariant1Requires.None,
                _ => null,
            };
        }
    }
}