﻿using System;
using System.Collections.Generic;
using Xendor.QueryModel.Expressions.EmbedCollection;
using Xendor.QueryModel.Expressions.FilterCollection;
using Xendor.QueryModel.Expressions.FullTextSearch;
using Xendor.QueryModel.Expressions.OrderBy;
using Xendor.QueryModel.Expressions.Paginate;
using Xendor.QueryModel.Expressions.Slice;

namespace Xendor.QueryModel
{
    public interface ICriteria
    {
        IPaginateExpression Paginate { get; }
        IOrderByExpression Sort { get; }
        IEmbedCollectionExpression Embeds { get; }
        IFullTextSearchExpression FullTextSearch { get; }
        ISliceExpression Slice { get; }
        string Path { get; }
        IFilterCollectionExpression Filters { get; }
        bool IsPaginate { get; }
        bool IsSlice { get; }

        void AddFilter(string name, string value, Type type);
    }
}