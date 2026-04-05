
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant2ContentHintVariant15Type
    {
        /// <summary>
        /// 
        /// </summary>
        FlagsConnectionString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant2ContentHintVariant15TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant2ContentHintVariant15Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant2ContentHintVariant15Type.FlagsConnectionString => "flags-connection-string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant2ContentHintVariant15Type? ToEnum(string value)
        {
            return value switch
            {
                "flags-connection-string" => RemoveProjectEnvResponseVariant2ContentHintVariant15Type.FlagsConnectionString,
                _ => null,
            };
        }
    }
}