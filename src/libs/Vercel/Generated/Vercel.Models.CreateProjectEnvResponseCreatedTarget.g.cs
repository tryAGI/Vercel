
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedTarget
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
    public static class CreateProjectEnvResponseCreatedTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedTarget value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedTarget.Development => "development",
                CreateProjectEnvResponseCreatedTarget.Preview => "preview",
                CreateProjectEnvResponseCreatedTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectEnvResponseCreatedTarget.Development,
                "preview" => CreateProjectEnvResponseCreatedTarget.Preview,
                "production" => CreateProjectEnvResponseCreatedTarget.Production,
                _ => null,
            };
        }
    }
}