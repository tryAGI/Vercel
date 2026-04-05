
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Value: deployment-url
    /// </summary>
    public enum CreateProjectCheckRequestRequires
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
    public static class CreateProjectCheckRequestRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectCheckRequestRequires value)
        {
            return value switch
            {
                CreateProjectCheckRequestRequires.BuildReady => "build-ready",
                CreateProjectCheckRequestRequires.DeploymentUrl => "deployment-url",
                CreateProjectCheckRequestRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectCheckRequestRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => CreateProjectCheckRequestRequires.BuildReady,
                "deployment-url" => CreateProjectCheckRequestRequires.DeploymentUrl,
                "none" => CreateProjectCheckRequestRequires.None,
                _ => null,
            };
        }
    }
}