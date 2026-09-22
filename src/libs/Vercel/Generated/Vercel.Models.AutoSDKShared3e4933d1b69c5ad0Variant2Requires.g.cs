
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3e4933d1b69c5ad0Variant2Requires
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
    public static class AutoSDKShared3e4933d1b69c5ad0Variant2RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3e4933d1b69c5ad0Variant2Requires value)
        {
            return value switch
            {
                AutoSDKShared3e4933d1b69c5ad0Variant2Requires.BuildReady => "build-ready",
                AutoSDKShared3e4933d1b69c5ad0Variant2Requires.DeploymentUrl => "deployment-url",
                AutoSDKShared3e4933d1b69c5ad0Variant2Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3e4933d1b69c5ad0Variant2Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => AutoSDKShared3e4933d1b69c5ad0Variant2Requires.BuildReady,
                "deployment-url" => AutoSDKShared3e4933d1b69c5ad0Variant2Requires.DeploymentUrl,
                "none" => AutoSDKShared3e4933d1b69c5ad0Variant2Requires.None,
                _ => null,
            };
        }
    }
}