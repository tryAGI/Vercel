
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede3c00aaf9d3a15beRequires
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
    public static class AutoSDKSharede3c00aaf9d3a15beRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede3c00aaf9d3a15beRequires value)
        {
            return value switch
            {
                AutoSDKSharede3c00aaf9d3a15beRequires.BuildReady => "build-ready",
                AutoSDKSharede3c00aaf9d3a15beRequires.DeploymentUrl => "deployment-url",
                AutoSDKSharede3c00aaf9d3a15beRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede3c00aaf9d3a15beRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => AutoSDKSharede3c00aaf9d3a15beRequires.BuildReady,
                "deployment-url" => AutoSDKSharede3c00aaf9d3a15beRequires.DeploymentUrl,
                "none" => AutoSDKSharede3c00aaf9d3a15beRequires.None,
                _ => null,
            };
        }
    }
}