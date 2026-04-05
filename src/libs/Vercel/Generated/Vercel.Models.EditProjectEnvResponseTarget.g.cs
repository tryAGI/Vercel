
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditProjectEnvResponseTarget
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
    public static class EditProjectEnvResponseTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditProjectEnvResponseTarget value)
        {
            return value switch
            {
                EditProjectEnvResponseTarget.Development => "development",
                EditProjectEnvResponseTarget.Preview => "preview",
                EditProjectEnvResponseTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditProjectEnvResponseTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => EditProjectEnvResponseTarget.Development,
                "preview" => EditProjectEnvResponseTarget.Preview,
                "production" => EditProjectEnvResponseTarget.Production,
                _ => null,
            };
        }
    }
}