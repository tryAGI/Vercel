
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
    /// </summary>
    public enum UpdateProjectResponseTracingSamplingRuleDestination
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
    public static class UpdateProjectResponseTracingSamplingRuleDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseTracingSamplingRuleDestination value)
        {
            return value switch
            {
                UpdateProjectResponseTracingSamplingRuleDestination.External => "external",
                UpdateProjectResponseTracingSamplingRuleDestination.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseTracingSamplingRuleDestination? ToEnum(string value)
        {
            return value switch
            {
                "external" => UpdateProjectResponseTracingSamplingRuleDestination.External,
                "internal" => UpdateProjectResponseTracingSamplingRuleDestination.Internal,
                _ => null,
            };
        }
    }
}