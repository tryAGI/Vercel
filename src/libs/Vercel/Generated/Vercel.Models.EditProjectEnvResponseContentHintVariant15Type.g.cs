
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditProjectEnvResponseContentHintVariant15Type
    {
        /// <summary>
        /// 
        /// </summary>
        FlagsConnectionString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditProjectEnvResponseContentHintVariant15TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditProjectEnvResponseContentHintVariant15Type value)
        {
            return value switch
            {
                EditProjectEnvResponseContentHintVariant15Type.FlagsConnectionString => "flags-connection-string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditProjectEnvResponseContentHintVariant15Type? ToEnum(string value)
        {
            return value switch
            {
                "flags-connection-string" => EditProjectEnvResponseContentHintVariant15Type.FlagsConnectionString,
                _ => null,
            };
        }
    }
}