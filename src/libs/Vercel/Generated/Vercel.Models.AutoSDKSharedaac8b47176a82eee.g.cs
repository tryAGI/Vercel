#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedaac8b47176a82eee : global::System.IEquatable<AutoSDKSharedaac8b47176a82eee>
    {
        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared32260c85dfc16e39? Shared32260c85dfc16e39 { get; init; }
#else
        public global::Vercel.AutoSDKShared32260c85dfc16e39? Shared32260c85dfc16e39 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared32260c85dfc16e39))]
#endif
        public bool IsShared32260c85dfc16e39 => Shared32260c85dfc16e39 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared32260c85dfc16e39(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared32260c85dfc16e39? value)
        {
            value = Shared32260c85dfc16e39;
            return IsShared32260c85dfc16e39;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared32260c85dfc16e39 PickShared32260c85dfc16e39() => IsShared32260c85dfc16e39
            ? Shared32260c85dfc16e39!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared32260c85dfc16e39' but the value was {ToString()}.");

        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared758f1bb5042637ce? Shared758f1bb5042637ce { get; init; }
#else
        public global::Vercel.AutoSDKShared758f1bb5042637ce? Shared758f1bb5042637ce { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared758f1bb5042637ce))]
#endif
        public bool IsShared758f1bb5042637ce => Shared758f1bb5042637ce != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared758f1bb5042637ce(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared758f1bb5042637ce? value)
        {
            value = Shared758f1bb5042637ce;
            return IsShared758f1bb5042637ce;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared758f1bb5042637ce PickShared758f1bb5042637ce() => IsShared758f1bb5042637ce
            ? Shared758f1bb5042637ce!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared758f1bb5042637ce' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedaac8b47176a82eee(global::Vercel.AutoSDKShared32260c85dfc16e39 value) => new AutoSDKSharedaac8b47176a82eee((global::Vercel.AutoSDKShared32260c85dfc16e39?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared32260c85dfc16e39?(AutoSDKSharedaac8b47176a82eee @this) => @this.Shared32260c85dfc16e39;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedaac8b47176a82eee(global::Vercel.AutoSDKShared32260c85dfc16e39? value)
        {
            Shared32260c85dfc16e39 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedaac8b47176a82eee FromShared32260c85dfc16e39(global::Vercel.AutoSDKShared32260c85dfc16e39? value) => new AutoSDKSharedaac8b47176a82eee(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedaac8b47176a82eee(global::Vercel.AutoSDKShared758f1bb5042637ce value) => new AutoSDKSharedaac8b47176a82eee((global::Vercel.AutoSDKShared758f1bb5042637ce?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared758f1bb5042637ce?(AutoSDKSharedaac8b47176a82eee @this) => @this.Shared758f1bb5042637ce;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedaac8b47176a82eee(global::Vercel.AutoSDKShared758f1bb5042637ce? value)
        {
            Shared758f1bb5042637ce = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedaac8b47176a82eee FromShared758f1bb5042637ce(global::Vercel.AutoSDKShared758f1bb5042637ce? value) => new AutoSDKSharedaac8b47176a82eee(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedaac8b47176a82eee(
            global::Vercel.AutoSDKShared32260c85dfc16e39? shared32260c85dfc16e39,
            global::Vercel.AutoSDKShared758f1bb5042637ce? shared758f1bb5042637ce
            )
        {
            Shared32260c85dfc16e39 = shared32260c85dfc16e39;
            Shared758f1bb5042637ce = shared758f1bb5042637ce;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared758f1bb5042637ce as object ??
            Shared32260c85dfc16e39 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared32260c85dfc16e39?.ToString() ??
            Shared758f1bb5042637ce?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared32260c85dfc16e39 && !IsShared758f1bb5042637ce || !IsShared32260c85dfc16e39 && IsShared758f1bb5042637ce;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared32260c85dfc16e39, TResult>? shared32260c85dfc16e39 = null,
            global::System.Func<global::Vercel.AutoSDKShared758f1bb5042637ce, TResult>? shared758f1bb5042637ce = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared32260c85dfc16e39 && shared32260c85dfc16e39 != null)
            {
                return shared32260c85dfc16e39(Shared32260c85dfc16e39!);
            }
            else if (IsShared758f1bb5042637ce && shared758f1bb5042637ce != null)
            {
                return shared758f1bb5042637ce(Shared758f1bb5042637ce!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared32260c85dfc16e39>? shared32260c85dfc16e39 = null,

            global::System.Action<global::Vercel.AutoSDKShared758f1bb5042637ce>? shared758f1bb5042637ce = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared32260c85dfc16e39)
            {
                shared32260c85dfc16e39?.Invoke(Shared32260c85dfc16e39!);
            }
            else if (IsShared758f1bb5042637ce)
            {
                shared758f1bb5042637ce?.Invoke(Shared758f1bb5042637ce!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared32260c85dfc16e39>? shared32260c85dfc16e39 = null,
            global::System.Action<global::Vercel.AutoSDKShared758f1bb5042637ce>? shared758f1bb5042637ce = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared32260c85dfc16e39)
            {
                shared32260c85dfc16e39?.Invoke(Shared32260c85dfc16e39!);
            }
            else if (IsShared758f1bb5042637ce)
            {
                shared758f1bb5042637ce?.Invoke(Shared758f1bb5042637ce!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared32260c85dfc16e39,
                typeof(global::Vercel.AutoSDKShared32260c85dfc16e39),
                Shared758f1bb5042637ce,
                typeof(global::Vercel.AutoSDKShared758f1bb5042637ce),
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
        public bool Equals(AutoSDKSharedaac8b47176a82eee other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared32260c85dfc16e39?>.Default.Equals(Shared32260c85dfc16e39, other.Shared32260c85dfc16e39) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared758f1bb5042637ce?>.Default.Equals(Shared758f1bb5042637ce, other.Shared758f1bb5042637ce)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedaac8b47176a82eee obj1, AutoSDKSharedaac8b47176a82eee obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedaac8b47176a82eee>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedaac8b47176a82eee obj1, AutoSDKSharedaac8b47176a82eee obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedaac8b47176a82eee o && Equals(o);
        }
    }
}
