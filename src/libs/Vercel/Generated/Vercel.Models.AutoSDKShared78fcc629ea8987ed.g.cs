#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared78fcc629ea8987ed : global::System.IEquatable<AutoSDKShared78fcc629ea8987ed>
    {
        /// <summary>
        /// Composable deployment-time policy. Each rule type holds a list of rules, one per environment scope.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared248d74bb1449b75f? Shared248d74bb1449b75f { get; init; }
#else
        public global::Vercel.AutoSDKShared248d74bb1449b75f? Shared248d74bb1449b75f { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared248d74bb1449b75f))]
#endif
        public bool IsShared248d74bb1449b75f => Shared248d74bb1449b75f != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared248d74bb1449b75f(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared248d74bb1449b75f? value)
        {
            value = Shared248d74bb1449b75f;
            return IsShared248d74bb1449b75f;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared248d74bb1449b75f PickShared248d74bb1449b75f() => IsShared248d74bb1449b75f
            ? Shared248d74bb1449b75f!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared248d74bb1449b75f' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AutoSDKShared78fcc629ea8987edVariant2 { get; init; }
#else
        public string? AutoSDKShared78fcc629ea8987edVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared78fcc629ea8987edVariant2))]
#endif
        public bool IsAutoSDKShared78fcc629ea8987edVariant2 => AutoSDKShared78fcc629ea8987edVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared78fcc629ea8987edVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AutoSDKShared78fcc629ea8987edVariant2;
            return IsAutoSDKShared78fcc629ea8987edVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAutoSDKShared78fcc629ea8987edVariant2() => IsAutoSDKShared78fcc629ea8987edVariant2
            ? AutoSDKShared78fcc629ea8987edVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared78fcc629ea8987edVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared78fcc629ea8987ed(global::Vercel.AutoSDKShared248d74bb1449b75f value) => new AutoSDKShared78fcc629ea8987ed((global::Vercel.AutoSDKShared248d74bb1449b75f?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared248d74bb1449b75f?(AutoSDKShared78fcc629ea8987ed @this) => @this.Shared248d74bb1449b75f;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared78fcc629ea8987ed(global::Vercel.AutoSDKShared248d74bb1449b75f? value)
        {
            Shared248d74bb1449b75f = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared78fcc629ea8987ed FromShared248d74bb1449b75f(global::Vercel.AutoSDKShared248d74bb1449b75f? value) => new AutoSDKShared78fcc629ea8987ed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared78fcc629ea8987ed(string value) => new AutoSDKShared78fcc629ea8987ed((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(AutoSDKShared78fcc629ea8987ed @this) => @this.AutoSDKShared78fcc629ea8987edVariant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared78fcc629ea8987ed(string? value)
        {
            AutoSDKShared78fcc629ea8987edVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared78fcc629ea8987ed FromAutoSDKShared78fcc629ea8987edVariant2(string? value) => new AutoSDKShared78fcc629ea8987ed(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared78fcc629ea8987ed(
            global::Vercel.AutoSDKShared248d74bb1449b75f? shared248d74bb1449b75f,
            string? autoSDKShared78fcc629ea8987edVariant2
            )
        {
            Shared248d74bb1449b75f = shared248d74bb1449b75f;
            AutoSDKShared78fcc629ea8987edVariant2 = autoSDKShared78fcc629ea8987edVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKShared78fcc629ea8987edVariant2 as object ??
            Shared248d74bb1449b75f as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared248d74bb1449b75f?.ToString() ??
            AutoSDKShared78fcc629ea8987edVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared248d74bb1449b75f || IsAutoSDKShared78fcc629ea8987edVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared248d74bb1449b75f, TResult>? shared248d74bb1449b75f = null,
            global::System.Func<string, TResult>? autoSDKShared78fcc629ea8987edVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared248d74bb1449b75f && shared248d74bb1449b75f != null)
            {
                return shared248d74bb1449b75f(Shared248d74bb1449b75f!);
            }
            else if (IsAutoSDKShared78fcc629ea8987edVariant2 && autoSDKShared78fcc629ea8987edVariant2 != null)
            {
                return autoSDKShared78fcc629ea8987edVariant2(AutoSDKShared78fcc629ea8987edVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared248d74bb1449b75f>? shared248d74bb1449b75f = null,

            global::System.Action<string>? autoSDKShared78fcc629ea8987edVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared248d74bb1449b75f)
            {
                shared248d74bb1449b75f?.Invoke(Shared248d74bb1449b75f!);
            }
            else if (IsAutoSDKShared78fcc629ea8987edVariant2)
            {
                autoSDKShared78fcc629ea8987edVariant2?.Invoke(AutoSDKShared78fcc629ea8987edVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared248d74bb1449b75f>? shared248d74bb1449b75f = null,
            global::System.Action<string>? autoSDKShared78fcc629ea8987edVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared248d74bb1449b75f)
            {
                shared248d74bb1449b75f?.Invoke(Shared248d74bb1449b75f!);
            }
            else if (IsAutoSDKShared78fcc629ea8987edVariant2)
            {
                autoSDKShared78fcc629ea8987edVariant2?.Invoke(AutoSDKShared78fcc629ea8987edVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared248d74bb1449b75f,
                typeof(global::Vercel.AutoSDKShared248d74bb1449b75f),
                AutoSDKShared78fcc629ea8987edVariant2,
                typeof(string),
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
        public bool Equals(AutoSDKShared78fcc629ea8987ed other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared248d74bb1449b75f?>.Default.Equals(Shared248d74bb1449b75f, other.Shared248d74bb1449b75f) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AutoSDKShared78fcc629ea8987edVariant2, other.AutoSDKShared78fcc629ea8987edVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared78fcc629ea8987ed obj1, AutoSDKShared78fcc629ea8987ed obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared78fcc629ea8987ed>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared78fcc629ea8987ed obj1, AutoSDKShared78fcc629ea8987ed obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared78fcc629ea8987ed o && Equals(o);
        }
    }
}
