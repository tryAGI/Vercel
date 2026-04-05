
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant2EnvTarget
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
    public static class FilterProjectEnvsResponseVariant2EnvTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant2EnvTarget value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant2EnvTarget.Development => "development",
                FilterProjectEnvsResponseVariant2EnvTarget.Preview => "preview",
                FilterProjectEnvsResponseVariant2EnvTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant2EnvTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => FilterProjectEnvsResponseVariant2EnvTarget.Development,
                "preview" => FilterProjectEnvsResponseVariant2EnvTarget.Preview,
                "production" => FilterProjectEnvsResponseVariant2EnvTarget.Production,
                _ => null,
            };
        }
    }
}