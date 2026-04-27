
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant166BuildQueueConfiguration
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
    public static class UserEventPayloadVariant166BuildQueueConfigurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant166BuildQueueConfiguration value)
        {
            return value switch
            {
                UserEventPayloadVariant166BuildQueueConfiguration.SkipNamespaceQueue => "SKIP_NAMESPACE_QUEUE",
                UserEventPayloadVariant166BuildQueueConfiguration.WaitForNamespaceQueue => "WAIT_FOR_NAMESPACE_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant166BuildQueueConfiguration? ToEnum(string value)
        {
            return value switch
            {
                "SKIP_NAMESPACE_QUEUE" => UserEventPayloadVariant166BuildQueueConfiguration.SkipNamespaceQueue,
                "WAIT_FOR_NAMESPACE_QUEUE" => UserEventPayloadVariant166BuildQueueConfiguration.WaitForNamespaceQueue,
                _ => null,
            };
        }
    }
}