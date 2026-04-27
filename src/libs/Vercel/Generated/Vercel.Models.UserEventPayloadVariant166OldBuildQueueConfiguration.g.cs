
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant166OldBuildQueueConfiguration
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
    public static class UserEventPayloadVariant166OldBuildQueueConfigurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant166OldBuildQueueConfiguration value)
        {
            return value switch
            {
                UserEventPayloadVariant166OldBuildQueueConfiguration.SkipNamespaceQueue => "SKIP_NAMESPACE_QUEUE",
                UserEventPayloadVariant166OldBuildQueueConfiguration.WaitForNamespaceQueue => "WAIT_FOR_NAMESPACE_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant166OldBuildQueueConfiguration? ToEnum(string value)
        {
            return value switch
            {
                "SKIP_NAMESPACE_QUEUE" => UserEventPayloadVariant166OldBuildQueueConfiguration.SkipNamespaceQueue,
                "WAIT_FOR_NAMESPACE_QUEUE" => UserEventPayloadVariant166OldBuildQueueConfiguration.WaitForNamespaceQueue,
                _ => null,
            };
        }
    }
}