#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared373105c7a8467265 : global::System.IEquatable<AutoSDKShared373105c7a8467265>
    {
        /// <summary>
        /// Check run backed by a project-level `check` definition.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared87d88207314b07b3? Shared87d88207314b07b3 { get; init; }
#else
        public global::Vercel.AutoSDKShared87d88207314b07b3? Shared87d88207314b07b3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared87d88207314b07b3))]
#endif
        public bool IsShared87d88207314b07b3 => Shared87d88207314b07b3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared87d88207314b07b3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared87d88207314b07b3? value)
        {
            value = Shared87d88207314b07b3;
            return IsShared87d88207314b07b3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared87d88207314b07b3 PickShared87d88207314b07b3() => Shared87d88207314b07b3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared87d88207314b07b3' but the value was {ToString()}.");

        /// <summary>
        /// Vercel CI check run without a parent `check` (no `checkId` field).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedca611ecff4bbfd16? Sharedca611ecff4bbfd16 { get; init; }
#else
        public global::Vercel.AutoSDKSharedca611ecff4bbfd16? Sharedca611ecff4bbfd16 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedca611ecff4bbfd16))]
#endif
        public bool IsSharedca611ecff4bbfd16 => Sharedca611ecff4bbfd16 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedca611ecff4bbfd16(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedca611ecff4bbfd16? value)
        {
            value = Sharedca611ecff4bbfd16;
            return IsSharedca611ecff4bbfd16;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedca611ecff4bbfd16 PickSharedca611ecff4bbfd16() => Sharedca611ecff4bbfd16 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedca611ecff4bbfd16' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared373105c7a8467265(global::Vercel.AutoSDKShared87d88207314b07b3 value) => new AutoSDKShared373105c7a8467265((global::Vercel.AutoSDKShared87d88207314b07b3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared87d88207314b07b3?(AutoSDKShared373105c7a8467265 @this) => @this.Shared87d88207314b07b3;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared373105c7a8467265(global::Vercel.AutoSDKShared87d88207314b07b3? value)
        {
            Shared87d88207314b07b3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared373105c7a8467265 FromShared87d88207314b07b3(global::Vercel.AutoSDKShared87d88207314b07b3? value) => new AutoSDKShared373105c7a8467265(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared373105c7a8467265(global::Vercel.AutoSDKSharedca611ecff4bbfd16 value) => new AutoSDKShared373105c7a8467265((global::Vercel.AutoSDKSharedca611ecff4bbfd16?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedca611ecff4bbfd16?(AutoSDKShared373105c7a8467265 @this) => @this.Sharedca611ecff4bbfd16;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared373105c7a8467265(global::Vercel.AutoSDKSharedca611ecff4bbfd16? value)
        {
            Sharedca611ecff4bbfd16 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared373105c7a8467265 FromSharedca611ecff4bbfd16(global::Vercel.AutoSDKSharedca611ecff4bbfd16? value) => new AutoSDKShared373105c7a8467265(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared373105c7a8467265(
            global::Vercel.AutoSDKShared87d88207314b07b3? shared87d88207314b07b3,
            global::Vercel.AutoSDKSharedca611ecff4bbfd16? sharedca611ecff4bbfd16
            )
        {
            Shared87d88207314b07b3 = shared87d88207314b07b3;
            Sharedca611ecff4bbfd16 = sharedca611ecff4bbfd16;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedca611ecff4bbfd16 as object ??
            Shared87d88207314b07b3 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared87d88207314b07b3?.ToString() ??
            Sharedca611ecff4bbfd16?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared87d88207314b07b3 && !IsSharedca611ecff4bbfd16 || !IsShared87d88207314b07b3 && IsSharedca611ecff4bbfd16;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared87d88207314b07b3, TResult>? shared87d88207314b07b3 = null,
            global::System.Func<global::Vercel.AutoSDKSharedca611ecff4bbfd16, TResult>? sharedca611ecff4bbfd16 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared87d88207314b07b3 is { } __value0 && shared87d88207314b07b3 != null)
            {
                return shared87d88207314b07b3(__value0);
            }
            else if (Sharedca611ecff4bbfd16 is { } __value1 && sharedca611ecff4bbfd16 != null)
            {
                return sharedca611ecff4bbfd16(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared87d88207314b07b3>? shared87d88207314b07b3 = null,

            global::System.Action<global::Vercel.AutoSDKSharedca611ecff4bbfd16>? sharedca611ecff4bbfd16 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared87d88207314b07b3 is { } __value0)
            {
                shared87d88207314b07b3?.Invoke(__value0);
            }
            else if (Sharedca611ecff4bbfd16 is { } __value1)
            {
                sharedca611ecff4bbfd16?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared87d88207314b07b3>? shared87d88207314b07b3 = null,
            global::System.Action<global::Vercel.AutoSDKSharedca611ecff4bbfd16>? sharedca611ecff4bbfd16 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared87d88207314b07b3 is { } __value0)
            {
                shared87d88207314b07b3?.Invoke(__value0);
            }
            else if (Sharedca611ecff4bbfd16 is { } __value1)
            {
                sharedca611ecff4bbfd16?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared87d88207314b07b3,
                typeof(global::Vercel.AutoSDKShared87d88207314b07b3),
                Sharedca611ecff4bbfd16,
                typeof(global::Vercel.AutoSDKSharedca611ecff4bbfd16),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AutoSDKShared373105c7a8467265 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared87d88207314b07b3?>.Default.Equals(Shared87d88207314b07b3, other.Shared87d88207314b07b3) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedca611ecff4bbfd16?>.Default.Equals(Sharedca611ecff4bbfd16, other.Sharedca611ecff4bbfd16)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared373105c7a8467265 obj1, AutoSDKShared373105c7a8467265 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared373105c7a8467265>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared373105c7a8467265 obj1, AutoSDKShared373105c7a8467265 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared373105c7a8467265 o && Equals(o);
        }
    }
}
