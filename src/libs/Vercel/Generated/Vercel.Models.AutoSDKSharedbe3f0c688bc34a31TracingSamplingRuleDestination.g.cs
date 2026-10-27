
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
    /// </summary>
    public enum AutoSDKSharedbe3f0c688bc34a31TracingSamplingRuleDestination
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
    public static class AutoSDKSharedbe3f0c688bc34a31TracingSamplingRuleDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbe3f0c688bc34a31TracingSamplingRuleDestination value)
        {
            return value switch
            {
                AutoSDKSharedbe3f0c688bc34a31TracingSamplingRuleDestination.External => "external",
                AutoSDKSharedbe3f0c688bc34a31TracingSamplingRuleDestination.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbe3f0c688bc34a31TracingSamplingRuleDestination? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKSharedbe3f0c688bc34a31TracingSamplingRuleDestination.External,
                "internal" => AutoSDKSharedbe3f0c688bc34a31TracingSamplingRuleDestination.Internal,
                _ => null,
            };
        }
    }
}