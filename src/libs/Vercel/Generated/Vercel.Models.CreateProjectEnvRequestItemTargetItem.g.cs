
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvRequestItemTargetItem
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
    public static class CreateProjectEnvRequestItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvRequestItemTargetItem value)
        {
            return value switch
            {
                CreateProjectEnvRequestItemTargetItem.Development => "development",
                CreateProjectEnvRequestItemTargetItem.Preview => "preview",
                CreateProjectEnvRequestItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvRequestItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectEnvRequestItemTargetItem.Development,
                "preview" => CreateProjectEnvRequestItemTargetItem.Preview,
                "production" => CreateProjectEnvRequestItemTargetItem.Production,
                _ => null,
            };
        }
    }
}