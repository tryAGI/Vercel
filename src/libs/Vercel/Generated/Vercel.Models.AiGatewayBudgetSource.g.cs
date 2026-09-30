
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Set when the row is inherited from the team's budget default.
    /// </summary>
    public enum AiGatewayBudgetSource
    {
        /// <summary>
        ///
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiGatewayBudgetSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayBudgetSource value)
        {
            return value switch
            {
                AiGatewayBudgetSource.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayBudgetSource? ToEnum(string value)
        {
            return value switch
            {
                "default" => AiGatewayBudgetSource.Default,
                _ => null,
            };
        }
    }
}