
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Value: public
    /// </summary>
    public enum CreateStorageStoresBlobRequestAccess
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStorageStoresBlobRequestAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStorageStoresBlobRequestAccess value)
        {
            return value switch
            {
                CreateStorageStoresBlobRequestAccess.Private => "private",
                CreateStorageStoresBlobRequestAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStorageStoresBlobRequestAccess? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateStorageStoresBlobRequestAccess.Private,
                "public" => CreateStorageStoresBlobRequestAccess.Public,
                _ => null,
            };
        }
    }
}