
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateLogDrainResponseSourceVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateLogDrainResponseSourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLogDrainResponseSourceVariant2Kind value)
        {
            return value switch
            {
                CreateLogDrainResponseSourceVariant2Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLogDrainResponseSourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => CreateLogDrainResponseSourceVariant2Kind.Integration,
                _ => null,
            };
        }
    }
}