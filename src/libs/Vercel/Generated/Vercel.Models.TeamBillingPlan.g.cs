
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamBillingPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Hobby,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamBillingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamBillingPlan value)
        {
            return value switch
            {
                TeamBillingPlan.Enterprise => "enterprise",
                TeamBillingPlan.Hobby => "hobby",
                TeamBillingPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamBillingPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => TeamBillingPlan.Enterprise,
                "hobby" => TeamBillingPlan.Hobby,
                "pro" => TeamBillingPlan.Pro,
                _ => null,
            };
        }
    }
}