
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Tracing destination this rule applies to. Derived server-side when project tracing is computed; accepted here so a computed config can round-trip through this endpoint.
    /// </summary>
    public enum UpdateProjectRequestTracingSamplingRuleDestination
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
    public static class UpdateProjectRequestTracingSamplingRuleDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestTracingSamplingRuleDestination value)
        {
            return value switch
            {
                UpdateProjectRequestTracingSamplingRuleDestination.External => "external",
                UpdateProjectRequestTracingSamplingRuleDestination.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestTracingSamplingRuleDestination? ToEnum(string value)
        {
            return value switch
            {
                "external" => UpdateProjectRequestTracingSamplingRuleDestination.External,
                "internal" => UpdateProjectRequestTracingSamplingRuleDestination.Internal,
                _ => null,
            };
        }
    }
}