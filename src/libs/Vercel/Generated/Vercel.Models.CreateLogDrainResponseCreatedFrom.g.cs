
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the log drain was created by an integration or by a user<br/>
    /// Example: integration
    /// </summary>
    public enum CreateLogDrainResponseCreatedFrom
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        SelfServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateLogDrainResponseCreatedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLogDrainResponseCreatedFrom value)
        {
            return value switch
            {
                CreateLogDrainResponseCreatedFrom.Integration => "integration",
                CreateLogDrainResponseCreatedFrom.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLogDrainResponseCreatedFrom? ToEnum(string value)
        {
            return value switch
            {
                "integration" => CreateLogDrainResponseCreatedFrom.Integration,
                "self-served" => CreateLogDrainResponseCreatedFrom.SelfServed,
                _ => null,
            };
        }
    }
}