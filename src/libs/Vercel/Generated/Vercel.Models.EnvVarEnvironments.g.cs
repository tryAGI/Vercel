
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum EnvVarEnvironments
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
    public static class EnvVarEnvironmentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvVarEnvironments value)
        {
            return value switch
            {
                EnvVarEnvironments.Development => "development",
                EnvVarEnvironments.Preview => "preview",
                EnvVarEnvironments.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvVarEnvironments? ToEnum(string value)
        {
            return value switch
            {
                "development" => EnvVarEnvironments.Development,
                "preview" => EnvVarEnvironments.Preview,
                "production" => EnvVarEnvironments.Production,
                _ => null,
            };
        }
    }
}