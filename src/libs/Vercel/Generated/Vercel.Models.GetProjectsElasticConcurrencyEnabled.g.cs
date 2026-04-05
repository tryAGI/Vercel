
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filter results by projects with elastic concurrency enabled<br/>
    /// Example: 1
    /// </summary>
    public enum GetProjectsElasticConcurrencyEnabled
    {
        /// <summary>
        /// 
        /// </summary>
        x0,
        /// <summary>
        /// 
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsElasticConcurrencyEnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsElasticConcurrencyEnabled value)
        {
            return value switch
            {
                GetProjectsElasticConcurrencyEnabled.x0 => "0",
                GetProjectsElasticConcurrencyEnabled.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsElasticConcurrencyEnabled? ToEnum(string value)
        {
            return value switch
            {
                "0" => GetProjectsElasticConcurrencyEnabled.x0,
                "1" => GetProjectsElasticConcurrencyEnabled.x1,
                _ => null,
            };
        }
    }
}