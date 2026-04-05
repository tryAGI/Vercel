
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum GetSharedEnvVarResponseTargetItem
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
    public static class GetSharedEnvVarResponseTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSharedEnvVarResponseTargetItem value)
        {
            return value switch
            {
                GetSharedEnvVarResponseTargetItem.Development => "development",
                GetSharedEnvVarResponseTargetItem.Preview => "preview",
                GetSharedEnvVarResponseTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSharedEnvVarResponseTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetSharedEnvVarResponseTargetItem.Development,
                "preview" => GetSharedEnvVarResponseTargetItem.Preview,
                "production" => GetSharedEnvVarResponseTargetItem.Production,
                _ => null,
            };
        }
    }
}