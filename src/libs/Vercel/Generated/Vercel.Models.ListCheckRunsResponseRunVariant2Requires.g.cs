
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunVariant2Requires
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
    public static class ListCheckRunsResponseRunVariant2RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant2Requires value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant2Requires.BuildReady => "build-ready",
                ListCheckRunsResponseRunVariant2Requires.DeploymentUrl => "deployment-url",
                ListCheckRunsResponseRunVariant2Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant2Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => ListCheckRunsResponseRunVariant2Requires.BuildReady,
                "deployment-url" => ListCheckRunsResponseRunVariant2Requires.DeploymentUrl,
                "none" => ListCheckRunsResponseRunVariant2Requires.None,
                _ => null,
            };
        }
    }
}