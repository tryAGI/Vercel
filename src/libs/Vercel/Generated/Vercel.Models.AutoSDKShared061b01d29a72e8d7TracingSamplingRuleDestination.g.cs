
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7TracingSamplingRuleDestination
    {
        /// <summary>
        ///
        /// </summary>
        External,
        /// <summary>
        ///
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared061b01d29a72e8d7TracingSamplingRuleDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7TracingSamplingRuleDestination value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7TracingSamplingRuleDestination.External => "external",
                AutoSDKShared061b01d29a72e8d7TracingSamplingRuleDestination.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7TracingSamplingRuleDestination? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKShared061b01d29a72e8d7TracingSamplingRuleDestination.External,
                "internal" => AutoSDKShared061b01d29a72e8d7TracingSamplingRuleDestination.Internal,
                _ => null,
            };
        }
    }
}