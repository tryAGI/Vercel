
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant3EnvTarget
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
    public static class FilterProjectEnvsResponseVariant3EnvTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant3EnvTarget value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant3EnvTarget.Development => "development",
                FilterProjectEnvsResponseVariant3EnvTarget.Preview => "preview",
                FilterProjectEnvsResponseVariant3EnvTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant3EnvTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => FilterProjectEnvsResponseVariant3EnvTarget.Development,
                "preview" => FilterProjectEnvsResponseVariant3EnvTarget.Preview,
                "production" => FilterProjectEnvsResponseVariant3EnvTarget.Production,
                _ => null,
            };
        }
    }
}