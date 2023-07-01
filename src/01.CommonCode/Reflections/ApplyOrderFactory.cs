using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Linq.Expressions;
using System.Reflection;

namespace Exercise.CommonCode.Reflections;

public interface IApplyOrder
{
}

public class ApplyOrderFactory<TDestination, TSource> : IApplyOrder
    where TDestination : class
    where TSource : class
{
    public List<ApplyOrderModel> ApplyOrderModels { get; private set; } = new();

    public ApplyOrderFactory<TDestination, TSource> Map<TDestinationMember, TSourceMember>(Expression<Func<TDestination, TDestinationMember>> member, Expression<Func<TSource, TSourceMember>> source)
    {
        ApplyOrderModels.Add(new ApplyOrderModel
        {
            PropertyInfo = member.GetPropertyAccess(),
            Expression = source
        });

        return this;
    }
}

public class ApplyOrderModel
{
    public PropertyInfo PropertyInfo { get; set; } = default!;
    public LambdaExpression Expression { get; set; } = default!;
}
