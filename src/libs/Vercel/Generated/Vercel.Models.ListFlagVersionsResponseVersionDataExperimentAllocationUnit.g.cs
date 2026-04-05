
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataExperimentAllocationUnit
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
    public static class ListFlagVersionsResponseVersionDataExperimentAllocationUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataExperimentAllocationUnit value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataExperimentAllocationUnit.CookieId => "cookieId",
                ListFlagVersionsResponseVersionDataExperimentAllocationUnit.UserId => "userId",
                ListFlagVersionsResponseVersionDataExperimentAllocationUnit.VisitorId => "visitorId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataExperimentAllocationUnit? ToEnum(string value)
        {
            return value switch
            {
                "cookieId" => ListFlagVersionsResponseVersionDataExperimentAllocationUnit.CookieId,
                "userId" => ListFlagVersionsResponseVersionDataExperimentAllocationUnit.UserId,
                "visitorId" => ListFlagVersionsResponseVersionDataExperimentAllocationUnit.VisitorId,
                _ => null,
            };
        }
    }
}