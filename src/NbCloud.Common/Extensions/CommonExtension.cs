using System;
using System.Linq.Expressions;

namespace NbCloud.Common.Extensions
{
    public static class CommonExtension
    {
        public static String NameOf<T, TT>(this Expression<Func<T, TT>> accessor)
        {
            return _nameof(accessor.Body);
        }

        public static String NameOf<T>(this Expression<Func<T>> accessor)
        {
            return _nameof(accessor.Body);
        }

        public static String NameOf<T, TT>(this T obj, Expression<Func<T, TT>> propertyAccessor)
        {
            return _nameof(propertyAccessor.Body);
        }

        private static String _nameof(Expression expression)
        {
            if (expression.NodeType == ExpressionType.MemberAccess)
            {
                var memberExpression = expression as MemberExpression;
                if (memberExpression == null)
                    return null;
                return memberExpression.Member.Name;
            }
            return null;
        }
    }
}
