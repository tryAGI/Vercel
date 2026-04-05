
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditProjectEnvResponseTargetItem
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
    public static class EditProjectEnvResponseTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditProjectEnvResponseTargetItem value)
        {
            return value switch
            {
                EditProjectEnvResponseTargetItem.Development => "development",
                EditProjectEnvResponseTargetItem.Preview => "preview",
                EditProjectEnvResponseTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditProjectEnvResponseTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => EditProjectEnvResponseTargetItem.Development,
                "preview" => EditProjectEnvResponseTargetItem.Preview,
                "production" => EditProjectEnvResponseTargetItem.Production,
                _ => null,
            };
        }
    }
}