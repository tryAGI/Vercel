
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant3Target
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant3TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant3Target value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant3Target.Development => "development",
                RemoveProjectEnvResponseVariant3Target.Preview => "preview",
                RemoveProjectEnvResponseVariant3Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant3Target? ToEnum(string value)
        {
            return value switch
            {
                "development" => RemoveProjectEnvResponseVariant3Target.Development,
                "preview" => RemoveProjectEnvResponseVariant3Target.Preview,
                "production" => RemoveProjectEnvResponseVariant3Target.Production,
                _ => null,
            };
        }
    }
}