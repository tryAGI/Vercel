
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Value: deployment-url
    /// </summary>
    public enum UpdateProjectCheckRequestRequires
    {
        /// <summary>
        /// 
        /// </summary>
        BuildReady,
        /// <summary>
        /// 
        /// </summary>
        DeploymentUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectCheckRequestRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectCheckRequestRequires value)
        {
            return value switch
            {
                UpdateProjectCheckRequestRequires.BuildReady => "build-ready",
                UpdateProjectCheckRequestRequires.DeploymentUrl => "deployment-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectCheckRequestRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => UpdateProjectCheckRequestRequires.BuildReady,
                "deployment-url" => UpdateProjectCheckRequestRequires.DeploymentUrl,
                _ => null,
            };
        }
    }
}