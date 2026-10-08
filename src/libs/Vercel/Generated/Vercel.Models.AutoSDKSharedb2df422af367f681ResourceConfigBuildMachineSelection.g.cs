
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineSelection
    {
        /// <summary>
        ///
        /// </summary>
        Elastic,
        /// <summary>
        ///
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}