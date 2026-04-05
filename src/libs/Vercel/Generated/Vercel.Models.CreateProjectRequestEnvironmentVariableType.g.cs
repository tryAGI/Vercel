
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Type of the ENV variable
    /// </summary>
    public enum CreateProjectRequestEnvironmentVariableType
    {
        /// <summary>
        /// 
        /// </summary>
        Encrypted,
        /// <summary>
        /// 
        /// </summary>
        Plain,
        /// <summary>
        /// 
        /// </summary>
        Sensitive,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectRequestEnvironmentVariableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestEnvironmentVariableType value)
        {
            return value switch
            {
                CreateProjectRequestEnvironmentVariableType.Encrypted => "encrypted",
                CreateProjectRequestEnvironmentVariableType.Plain => "plain",
                CreateProjectRequestEnvironmentVariableType.Sensitive => "sensitive",
                CreateProjectRequestEnvironmentVariableType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestEnvironmentVariableType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => CreateProjectRequestEnvironmentVariableType.Encrypted,
                "plain" => CreateProjectRequestEnvironmentVariableType.Plain,
                "sensitive" => CreateProjectRequestEnvironmentVariableType.Sensitive,
                "system" => CreateProjectRequestEnvironmentVariableType.System,
                _ => null,
            };
        }
    }
}