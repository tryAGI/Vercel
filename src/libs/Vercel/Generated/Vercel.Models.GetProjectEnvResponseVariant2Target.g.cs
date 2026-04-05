
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant2Target
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
    public static class GetProjectEnvResponseVariant2TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant2Target value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant2Target.Development => "development",
                GetProjectEnvResponseVariant2Target.Preview => "preview",
                GetProjectEnvResponseVariant2Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant2Target? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectEnvResponseVariant2Target.Development,
                "preview" => GetProjectEnvResponseVariant2Target.Preview,
                "production" => GetProjectEnvResponseVariant2Target.Production,
                _ => null,
            };
        }
    }
}