
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant1ItemTarget
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
    public static class RemoveProjectEnvResponseVariant1ItemTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant1ItemTarget value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant1ItemTarget.Development => "development",
                RemoveProjectEnvResponseVariant1ItemTarget.Preview => "preview",
                RemoveProjectEnvResponseVariant1ItemTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant1ItemTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => RemoveProjectEnvResponseVariant1ItemTarget.Development,
                "preview" => RemoveProjectEnvResponseVariant1ItemTarget.Preview,
                "production" => RemoveProjectEnvResponseVariant1ItemTarget.Production,
                _ => null,
            };
        }
    }
}