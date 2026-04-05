
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvRequestTargetItem
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
    public static class CreateProjectEnvRequestTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvRequestTargetItem value)
        {
            return value switch
            {
                CreateProjectEnvRequestTargetItem.Development => "development",
                CreateProjectEnvRequestTargetItem.Preview => "preview",
                CreateProjectEnvRequestTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvRequestTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectEnvRequestTargetItem.Development,
                "preview" => CreateProjectEnvRequestTargetItem.Preview,
                "production" => CreateProjectEnvRequestTargetItem.Production,
                _ => null,
            };
        }
    }
}