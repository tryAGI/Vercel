
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunRequires
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
    public static class ListCheckRunsResponseRunRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunRequires value)
        {
            return value switch
            {
                ListCheckRunsResponseRunRequires.BuildReady => "build-ready",
                ListCheckRunsResponseRunRequires.DeploymentUrl => "deployment-url",
                ListCheckRunsResponseRunRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => ListCheckRunsResponseRunRequires.BuildReady,
                "deployment-url" => ListCheckRunsResponseRunRequires.DeploymentUrl,
                "none" => ListCheckRunsResponseRunRequires.None,
                _ => null,
            };
        }
    }
}