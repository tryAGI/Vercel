
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2SourceVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainResponseVariant2SourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2SourceVariant2Kind value)
        {
            return value switch
            {
                CreateDrainResponseVariant2SourceVariant2Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2SourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => CreateDrainResponseVariant2SourceVariant2Kind.Integration,
                _ => null,
            };
        }
    }
}