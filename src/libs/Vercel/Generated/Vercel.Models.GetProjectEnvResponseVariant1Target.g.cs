
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant1Target
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
    public static class GetProjectEnvResponseVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant1Target value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant1Target.Development => "development",
                GetProjectEnvResponseVariant1Target.Preview => "preview",
                GetProjectEnvResponseVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectEnvResponseVariant1Target.Development,
                "preview" => GetProjectEnvResponseVariant1Target.Preview,
                "production" => GetProjectEnvResponseVariant1Target.Production,
                _ => null,
            };
        }
    }
}