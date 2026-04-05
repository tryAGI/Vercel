
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditProjectEnvRequestTargetItem
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
    public static class EditProjectEnvRequestTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditProjectEnvRequestTargetItem value)
        {
            return value switch
            {
                EditProjectEnvRequestTargetItem.Development => "development",
                EditProjectEnvRequestTargetItem.Preview => "preview",
                EditProjectEnvRequestTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditProjectEnvRequestTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => EditProjectEnvRequestTargetItem.Development,
                "preview" => EditProjectEnvRequestTargetItem.Preview,
                "production" => EditProjectEnvRequestTargetItem.Production,
                _ => null,
            };
        }
    }
}