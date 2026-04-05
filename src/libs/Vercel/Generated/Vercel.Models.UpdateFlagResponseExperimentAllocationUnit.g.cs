
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseExperimentAllocationUnit
    {
        /// <summary>
        /// 
        /// </summary>
        CookieId,
        /// <summary>
        /// 
        /// </summary>
        UserId,
        /// <summary>
        /// 
        /// </summary>
        VisitorId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseExperimentAllocationUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseExperimentAllocationUnit value)
        {
            return value switch
            {
                UpdateFlagResponseExperimentAllocationUnit.CookieId => "cookieId",
                UpdateFlagResponseExperimentAllocationUnit.UserId => "userId",
                UpdateFlagResponseExperimentAllocationUnit.VisitorId => "visitorId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseExperimentAllocationUnit? ToEnum(string value)
        {
            return value switch
            {
                "cookieId" => UpdateFlagResponseExperimentAllocationUnit.CookieId,
                "userId" => UpdateFlagResponseExperimentAllocationUnit.UserId,
                "visitorId" => UpdateFlagResponseExperimentAllocationUnit.VisitorId,
                _ => null,
            };
        }
    }
}