
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectCheckResponseRequires
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
    public static class UpdateProjectCheckResponseRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectCheckResponseRequires value)
        {
            return value switch
            {
                UpdateProjectCheckResponseRequires.BuildReady => "build-ready",
                UpdateProjectCheckResponseRequires.DeploymentUrl => "deployment-url",
                UpdateProjectCheckResponseRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectCheckResponseRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => UpdateProjectCheckResponseRequires.BuildReady,
                "deployment-url" => UpdateProjectCheckResponseRequires.DeploymentUrl,
                "none" => UpdateProjectCheckResponseRequires.None,
                _ => null,
            };
        }
    }
}