
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51TracingSamplingRuleDestination
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
    public static class AutoSDKSharedea12f8422dc06e51TracingSamplingRuleDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51TracingSamplingRuleDestination value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51TracingSamplingRuleDestination.External => "external",
                AutoSDKSharedea12f8422dc06e51TracingSamplingRuleDestination.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51TracingSamplingRuleDestination? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKSharedea12f8422dc06e51TracingSamplingRuleDestination.External,
                "internal" => AutoSDKSharedea12f8422dc06e51TracingSamplingRuleDestination.Internal,
                _ => null,
            };
        }
    }
}