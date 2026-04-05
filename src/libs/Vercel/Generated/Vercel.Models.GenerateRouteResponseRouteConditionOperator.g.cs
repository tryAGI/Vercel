
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateRouteResponseRouteConditionOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Exists,
        /// <summary>
        /// 
        /// </summary>
        Re,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateRouteResponseRouteConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateRouteResponseRouteConditionOperator value)
        {
            return value switch
            {
                GenerateRouteResponseRouteConditionOperator.Contains => "contains",
                GenerateRouteResponseRouteConditionOperator.Eq => "eq",
                GenerateRouteResponseRouteConditionOperator.Exists => "exists",
                GenerateRouteResponseRouteConditionOperator.Re => "re",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateRouteResponseRouteConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => GenerateRouteResponseRouteConditionOperator.Contains,
                "eq" => GenerateRouteResponseRouteConditionOperator.Eq,
                "exists" => GenerateRouteResponseRouteConditionOperator.Exists,
                "re" => GenerateRouteResponseRouteConditionOperator.Re,
                _ => null,
            };
        }
    }
}