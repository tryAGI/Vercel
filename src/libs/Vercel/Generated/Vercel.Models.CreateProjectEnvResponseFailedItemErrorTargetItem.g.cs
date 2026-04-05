
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseFailedItemErrorTargetItem
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
    public static class CreateProjectEnvResponseFailedItemErrorTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseFailedItemErrorTargetItem value)
        {
            return value switch
            {
                CreateProjectEnvResponseFailedItemErrorTargetItem.Development => "development",
                CreateProjectEnvResponseFailedItemErrorTargetItem.Preview => "preview",
                CreateProjectEnvResponseFailedItemErrorTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseFailedItemErrorTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectEnvResponseFailedItemErrorTargetItem.Development,
                "preview" => CreateProjectEnvResponseFailedItemErrorTargetItem.Preview,
                "production" => CreateProjectEnvResponseFailedItemErrorTargetItem.Production,
                _ => null,
            };
        }
    }
}