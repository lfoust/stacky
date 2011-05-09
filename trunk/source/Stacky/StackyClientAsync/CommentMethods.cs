using System;
using System.Collections.Generic;

namespace Stacky
{
#if SILVERLIGHT
    public partial class StackyClient
#else
    public partial class StackyClientAsync
#endif
    {
        public virtual void GetComments(IEnumerable<int> fromUserIds, Action<IPagedList<Comment>> onSuccess, Action<ApiException> onError, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? toUserId = null, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            string[] urlParameters = null;
            if (toUserId.HasValue)
            {
                urlParameters = new string[] { fromUserIds.Vectorize(), "comments", toUserId.ToString() };
            }
            else
            {
                urlParameters = new string[] { fromUserIds.Vectorize(), "comments" };
            }

            MakeRequest<CommentResponse>("users", urlParameters, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection)
            }, (items) => onSuccess(new PagedList<Comment>(items.Comments, items)), onError);
        }

        public virtual void GetComments(int fromUserId, Action<IPagedList<Comment>> onSuccess, Action<ApiException> onError, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? toUserId = null, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            GetComments(fromUserId.ToArray(), onSuccess, onError, sortBy, sortDirection, toUserId, page, pageSize, fromDate, toDate);
        }

        public virtual void GetCommentsByPost(int postId, Action<IPagedList<Comment>> onSuccess, Action<ApiException> onError, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            GetCommentsByPost(postId.ToArray(), onSuccess, onError, sortBy, sortDirection, page, pageSize, fromDate, toDate);
        }

        public virtual void GetCommentsByPost(IEnumerable<int> postIds, Action<IPagedList<Comment>> onSuccess, Action<ApiException> onError, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            MakeRequest<CommentResponse>("posts", new string[] { postIds.Vectorize(), "comments" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
            }, (items) => onSuccess(new PagedList<Comment>(items.Comments, items)), onError);
        }

        public virtual void GetAnswerComments(int answerId, Action<IPagedList<Comment>> onSuccess, Action<ApiException> onError, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            GetAnswerComments(answerId.ToArray(), onSuccess, onError, sortBy, sortDirection, page, pageSize, fromDate, toDate, min, max);
        }

        public virtual void GetAnswerComments(IEnumerable<int> answerIds, Action<IPagedList<Comment>> onSuccess, Action<ApiException> onError, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            MakeRequest<CommentResponse>("answers", new string[] { answerIds.Vectorize(), "comments" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                min = min ?? null,
                max = max ?? null
            }, response => onSuccess(new PagedList<Comment>(response.Comments, response)), onError);
        }

        /// <summary>
        /// Gets all the comments in the site
        /// </summary>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param>
        /// <param name="sortBy">How the current sort should be ordered.</param>
        /// <param name="sortDirection"></param>
        /// <param name="page">The pagination offset for the current collection. Affected by the specified pagesize.</param>
        /// <param name="pageSize">The number of collection results to display during pagination. Should be between 0 and 100 inclusive.</param>
        /// <param name="fromDate"> Unix timestamp of the minimum creation date on a returned item.</param>
        /// <param name="toDate">Unix timestamp of the maximum creation date on a returned item.</param>
        /// <param name="min">Minimum of the range to include in the response according to the current sort.</param>
        /// <param name="max">Maximum of the range to include in the response according to the current sort.</param>
        /// <returns></returns>
        public virtual void GetComments(Action<IPagedList<Comment>> onSuccess, Action<ApiException> onError, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            MakeRequest<CommentResponse>("answers", null, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                min = min ?? null,
                max = max ?? null
            }, response => onSuccess(new PagedList<Comment>(response.Comments, response)), onError);
        }
    }
}