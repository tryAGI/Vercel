
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedTargetItem
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
    public static class CreateProjectEnvResponseCreatedTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedTargetItem value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedTargetItem.Development => "development",
                CreateProjectEnvResponseCreatedTargetItem.Preview => "preview",
                CreateProjectEnvResponseCreatedTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectEnvResponseCreatedTargetItem.Development,
                "preview" => CreateProjectEnvResponseCreatedTargetItem.Preview,
                "production" => CreateProjectEnvResponseCreatedTargetItem.Production,
                _ => null,
            };
        }
    }
}