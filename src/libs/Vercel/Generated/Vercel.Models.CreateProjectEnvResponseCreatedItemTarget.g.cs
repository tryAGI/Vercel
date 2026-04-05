
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedItemTarget
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
    public static class CreateProjectEnvResponseCreatedItemTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedItemTarget value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedItemTarget.Development => "development",
                CreateProjectEnvResponseCreatedItemTarget.Preview => "preview",
                CreateProjectEnvResponseCreatedItemTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedItemTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectEnvResponseCreatedItemTarget.Development,
                "preview" => CreateProjectEnvResponseCreatedItemTarget.Preview,
                "production" => CreateProjectEnvResponseCreatedItemTarget.Production,
                _ => null,
            };
        }
    }
}