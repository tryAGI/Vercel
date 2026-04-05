
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseFailedItemErrorTarget
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
    public static class CreateProjectEnvResponseFailedItemErrorTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseFailedItemErrorTarget value)
        {
            return value switch
            {
                CreateProjectEnvResponseFailedItemErrorTarget.Development => "development",
                CreateProjectEnvResponseFailedItemErrorTarget.Preview => "preview",
                CreateProjectEnvResponseFailedItemErrorTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseFailedItemErrorTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectEnvResponseFailedItemErrorTarget.Development,
                "preview" => CreateProjectEnvResponseFailedItemErrorTarget.Preview,
                "production" => CreateProjectEnvResponseFailedItemErrorTarget.Production,
                _ => null,
            };
        }
    }
}