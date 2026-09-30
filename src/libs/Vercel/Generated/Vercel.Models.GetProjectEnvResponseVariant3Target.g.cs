
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectEnvResponseVariant3Target
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
    public static class GetProjectEnvResponseVariant3TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant3Target value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant3Target.Development => "development",
                GetProjectEnvResponseVariant3Target.Preview => "preview",
                GetProjectEnvResponseVariant3Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant3Target? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectEnvResponseVariant3Target.Development,
                "preview" => GetProjectEnvResponseVariant3Target.Preview,
                "production" => GetProjectEnvResponseVariant3Target.Production,
                _ => null,
            };
        }
    }
}