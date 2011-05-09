using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacky
{
#if SILVERLIGHT
    public partial class StackyClient
#else
    public partial class StackyClientAsync
#endif
    {
        public virtual void GetUsersAnswers(int userId, Action<IPagedList<Answer>> onSuccess, Action<ApiException> onError, QuestionsByUserSort sortBy = QuestionsByUserSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false)
        {
            GetUsersAnswers(userId.ToArray(), onSuccess, onError, sortBy, sortDirection, page, pageSize, includeBody, includeComments);
        }

        public virtual void GetUsersAnswers(IEnumerable<int> userIds, Action<IPagedList<Answer>> onSuccess, Action<ApiException> onError, QuestionsByUserSort sortBy = QuestionsByUserSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, int? min = null, int? max = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            MakeRequest<AnswerResponse>("users", new string[] { userIds.Vectorize(), "answers" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                body = includeBody ? (bool?)true : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                min = min ?? null,
                max = max ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null
            }, (items) => onSuccess(new PagedList<Answer>(items.Answers, items)), onError);
        }

        public virtual void GetQuestionAnswers(int questionId, Action<IPagedList<Answer>> onSuccess, Action<ApiException> onError, QuestionsByUserSort sortBy = QuestionsByUserSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false)
        {
            GetQuestionAnswers(questionId.ToArray(), onSuccess, onError, sortBy, sortDirection, page, pageSize, includeBody);
        }

        public virtual void GetQuestionAnswers(IEnumerable<int> questionIds, Action<IPagedList<Answer>> onSuccess, Action<ApiException> onError, QuestionsByUserSort sortBy = QuestionsByUserSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, int? min = null, int? max = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            MakeRequest<AnswerResponse>("questions", new string[] { questionIds.Vectorize(), "answers" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                body = includeBody ? (bool?)true : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                min = min ?? null,
                max = max ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null
            }, (items) => onSuccess(new PagedList<Answer>(items.Answers, items)), onError);
        }

        public virtual void GetAnswer(int answerId, Action<Answer> onSuccess, Action<ApiException> onError, bool includeBody = true, bool includeComments = true)
        {
            GetAnswers(answerId.ToArray(), answers => onSuccess(answers.FirstOrDefault()), onError, includeBody: includeBody, includeComments: includeComments);
        }

        public virtual void GetAnswers(IEnumerable<int> answerIds, Action<IPagedList<Answer>> onSuccess, Action<ApiException> onError, AnswerSort sortBy = AnswerSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, int? min = null, int? max = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            MakeRequest<AnswerResponse>("answers", new string[] { answerIds.Vectorize() }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                body = includeBody ? (bool?)true : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                min = min ?? null,
                max = max ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null
            }, (items) => onSuccess(new PagedList<Answer>(items.Answers, items)), onError);
        }

        /// <summary>
        /// Returns all the answers in the system
        /// </summary>
        /// <param name="onSuccess">The callback on successful execution</param>
        /// <param name="onError">The callback if an error occurs</param>
        /// <param name="sortBy">How a collection should be sorted.</param>
        /// <param name="sortDirection"></param>
        /// <param name="page">The pagination offset for the current collection. Affected by the specified pagesize.</param>
        /// <param name="pageSize">The number of collection results to display during pagination. Should be between 0 and 100 inclusive.</param>
        /// <param name="includeBody">When "true", a post's body will be included in the response.</param>
        /// <param name="includeComments">When "true", any comments on a post will be included in the response.</param>
        /// <param name="includeAnswers"> When "true", the answers to a question will be returned</param>
        /// <param name="min">Minimum of the range to include in the response according to the current sort.</param>
        /// <param name="max">Maximum of the range to include in the response according to the current sort.</param>
        /// <param name="fromDate">Unix timestamp of the minimum creation date on a returned item.</param>
        /// <param name="toDate">Unix timestamp of the maximum creation date on a returned item.</param>
        /// <returns></returns>
        public virtual void GetAnswers(Action<IPagedList<Answer>> onSuccess, Action<ApiException> onError, AnswerSort sortBy = AnswerSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, bool includeAnswers = false, int? min = null, int? max = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            MakeRequest<AnswerResponse>("answers", null, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                body = includeBody ? (bool?)true : null,
                comments = includeComments ? (bool?)true : null,
                answers = includeAnswers ? (bool?)true : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                min = min ?? null,
                max = max ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null
            }, (items) => onSuccess(new PagedList<Answer>(items.Answers, items)), onError);
        }
    }
}