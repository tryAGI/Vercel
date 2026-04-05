
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectChecksResponseCheckRequires
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
    public static class ListProjectChecksResponseCheckRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectChecksResponseCheckRequires value)
        {
            return value switch
            {
                ListProjectChecksResponseCheckRequires.BuildReady => "build-ready",
                ListProjectChecksResponseCheckRequires.DeploymentUrl => "deployment-url",
                ListProjectChecksResponseCheckRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectChecksResponseCheckRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => ListProjectChecksResponseCheckRequires.BuildReady,
                "deployment-url" => ListProjectChecksResponseCheckRequires.DeploymentUrl,
                "none" => ListProjectChecksResponseCheckRequires.None,
                _ => null,
            };
        }
    }
}