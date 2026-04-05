
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagExperimentAllocationUnit
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
    public static class FlagExperimentAllocationUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagExperimentAllocationUnit value)
        {
            return value switch
            {
                FlagExperimentAllocationUnit.CookieId => "cookieId",
                FlagExperimentAllocationUnit.UserId => "userId",
                FlagExperimentAllocationUnit.VisitorId => "visitorId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagExperimentAllocationUnit? ToEnum(string value)
        {
            return value switch
            {
                "cookieId" => FlagExperimentAllocationUnit.CookieId,
                "userId" => FlagExperimentAllocationUnit.UserId,
                "visitorId" => FlagExperimentAllocationUnit.VisitorId,
                _ => null,
            };
        }
    }
}