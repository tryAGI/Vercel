
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A project-default store is a private blob store that is lazily created per-project, uses OIDC auth instead of read-write tokens, and cannot be modified through standard store mutation APIs. Undefined for legacy stores.
    /// </summary>
    public enum CreateStorageStoresBlobResponseStoreKind
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectDefault,
        /// <summary>
        /// 
        /// </summary>
        UserCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStorageStoresBlobResponseStoreKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStorageStoresBlobResponseStoreKind value)
        {
            return value switch
            {
                CreateStorageStoresBlobResponseStoreKind.ProjectDefault => "project-default",
                CreateStorageStoresBlobResponseStoreKind.UserCreated => "user-created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStorageStoresBlobResponseStoreKind? ToEnum(string value)
        {
            return value switch
            {
                "project-default" => CreateStorageStoresBlobResponseStoreKind.ProjectDefault,
                "user-created" => CreateStorageStoresBlobResponseStoreKind.UserCreated,
                _ => null,
            };
        }
    }
}