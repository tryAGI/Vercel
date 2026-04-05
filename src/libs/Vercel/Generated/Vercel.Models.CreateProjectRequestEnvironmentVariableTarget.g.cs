
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectRequestEnvironmentVariableTarget
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
    public static class CreateProjectRequestEnvironmentVariableTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestEnvironmentVariableTarget value)
        {
            return value switch
            {
                CreateProjectRequestEnvironmentVariableTarget.Development => "development",
                CreateProjectRequestEnvironmentVariableTarget.Preview => "preview",
                CreateProjectRequestEnvironmentVariableTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestEnvironmentVariableTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectRequestEnvironmentVariableTarget.Development,
                "preview" => CreateProjectRequestEnvironmentVariableTarget.Preview,
                "production" => CreateProjectRequestEnvironmentVariableTarget.Production,
                _ => null,
            };
        }
    }
}