
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectCheckResponseRequires
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
    public static class CreateProjectCheckResponseRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectCheckResponseRequires value)
        {
            return value switch
            {
                CreateProjectCheckResponseRequires.BuildReady => "build-ready",
                CreateProjectCheckResponseRequires.DeploymentUrl => "deployment-url",
                CreateProjectCheckResponseRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectCheckResponseRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => CreateProjectCheckResponseRequires.BuildReady,
                "deployment-url" => CreateProjectCheckResponseRequires.DeploymentUrl,
                "none" => CreateProjectCheckResponseRequires.None,
                _ => null,
            };
        }
    }
}