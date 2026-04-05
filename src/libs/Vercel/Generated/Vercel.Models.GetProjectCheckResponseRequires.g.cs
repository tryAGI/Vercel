
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectCheckResponseRequires
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
    public static class GetProjectCheckResponseRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectCheckResponseRequires value)
        {
            return value switch
            {
                GetProjectCheckResponseRequires.BuildReady => "build-ready",
                GetProjectCheckResponseRequires.DeploymentUrl => "deployment-url",
                GetProjectCheckResponseRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectCheckResponseRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => GetProjectCheckResponseRequires.BuildReady,
                "deployment-url" => GetProjectCheckResponseRequires.DeploymentUrl,
                "none" => GetProjectCheckResponseRequires.None,
                _ => null,
            };
        }
    }
}