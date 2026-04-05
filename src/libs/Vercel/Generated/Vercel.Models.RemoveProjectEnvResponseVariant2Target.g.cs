
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant2Target
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
    public static class RemoveProjectEnvResponseVariant2TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant2Target value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant2Target.Development => "development",
                RemoveProjectEnvResponseVariant2Target.Preview => "preview",
                RemoveProjectEnvResponseVariant2Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant2Target? ToEnum(string value)
        {
            return value switch
            {
                "development" => RemoveProjectEnvResponseVariant2Target.Development,
                "preview" => RemoveProjectEnvResponseVariant2Target.Preview,
                "production" => RemoveProjectEnvResponseVariant2Target.Production,
                _ => null,
            };
        }
    }
}