
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBillingPlansResponsePlanScope
    {
        /// <summary>
        /// 
        /// </summary>
        Installation,
        /// <summary>
        /// 
        /// </summary>
        Resource,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBillingPlansResponsePlanScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBillingPlansResponsePlanScope value)
        {
            return value switch
            {
                GetBillingPlansResponsePlanScope.Installation => "installation",
                GetBillingPlansResponsePlanScope.Resource => "resource",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBillingPlansResponsePlanScope? ToEnum(string value)
        {
            return value switch
            {
                "installation" => GetBillingPlansResponsePlanScope.Installation,
                "resource" => GetBillingPlansResponsePlanScope.Resource,
                _ => null,
            };
        }
    }
}