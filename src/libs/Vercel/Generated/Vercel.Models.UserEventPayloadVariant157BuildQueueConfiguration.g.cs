
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant157BuildQueueConfiguration
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
    public static class UserEventPayloadVariant157BuildQueueConfigurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant157BuildQueueConfiguration value)
        {
            return value switch
            {
                UserEventPayloadVariant157BuildQueueConfiguration.SkipNamespaceQueue => "SKIP_NAMESPACE_QUEUE",
                UserEventPayloadVariant157BuildQueueConfiguration.WaitForNamespaceQueue => "WAIT_FOR_NAMESPACE_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant157BuildQueueConfiguration? ToEnum(string value)
        {
            return value switch
            {
                "SKIP_NAMESPACE_QUEUE" => UserEventPayloadVariant157BuildQueueConfiguration.SkipNamespaceQueue,
                "WAIT_FOR_NAMESPACE_QUEUE" => UserEventPayloadVariant157BuildQueueConfiguration.WaitForNamespaceQueue,
                _ => null,
            };
        }
    }
}