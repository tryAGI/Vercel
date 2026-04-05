
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filter results by build queue configuration. SKIP_NAMESPACE_QUEUE includes projects without a configuration set.<br/>
    /// Example: SKIP_NAMESPACE_QUEUE
    /// </summary>
    public enum GetProjectsBuildQueueConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        SkipNamespaceQueue,
        /// <summary>
        /// 
        /// </summary>
        WaitForNamespaceQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsBuildQueueConfigurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsBuildQueueConfiguration value)
        {
            return value switch
            {
                GetProjectsBuildQueueConfiguration.SkipNamespaceQueue => "SKIP_NAMESPACE_QUEUE",
                GetProjectsBuildQueueConfiguration.WaitForNamespaceQueue => "WAIT_FOR_NAMESPACE_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsBuildQueueConfiguration? ToEnum(string value)
        {
            return value switch
            {
                "SKIP_NAMESPACE_QUEUE" => GetProjectsBuildQueueConfiguration.SkipNamespaceQueue,
                "WAIT_FOR_NAMESPACE_QUEUE" => GetProjectsBuildQueueConfiguration.WaitForNamespaceQueue,
                _ => null,
            };
        }
    }
}