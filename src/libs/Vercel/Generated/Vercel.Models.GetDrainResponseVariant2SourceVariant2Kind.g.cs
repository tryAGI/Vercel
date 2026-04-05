
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2SourceVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainResponseVariant2SourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2SourceVariant2Kind value)
        {
            return value switch
            {
                GetDrainResponseVariant2SourceVariant2Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2SourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => GetDrainResponseVariant2SourceVariant2Kind.Integration,
                _ => null,
            };
        }
    }
}