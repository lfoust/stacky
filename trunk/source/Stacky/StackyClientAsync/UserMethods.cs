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
        public virtual void GetUsers(Action<IPagedList<User>> onSuccess, Action<ApiException> onError, UserSort sortBy = UserSort.Reputation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, string filter = null)
        {
            MakeRequest<UserResponse>("users", null, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                filter = filter,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection)
            }, (items) => onSuccess(new PagedList<User>(items.Users, items)), onError);
        }

        public virtual void GetUsers(IEnumerable<int> userIds, Action<IPagedList<User>> onSuccess, Action<ApiException> onError = null)
        {
            MakeRequest<UserResponse>("users", new string[] { userIds.Vectorize() }, new
            {
                key = apiKey
            }, (items) => onSuccess(new PagedList<User>(items.Users, items)), onError);
        }

        public virtual void GetUser(int userId, Action<User> onSuccess, Action<ApiException> onError = null)
        {
            GetUsers(new int[] { userId }, results => onSuccess(results.FirstOrDefault()), onError);
        }

        public virtual void GetUserMentions(int userId, Action<IPagedList<Comment>> onSuccess, Action<ApiException> onError, UserMentionSort sortBy = UserMentionSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            GetUserMentions(new int[] { userId }, onSuccess, onError, sortBy, sortDirection, page, pageSize, fromDate, toDate, min, max);
        }

        public virtual void GetUserMentions(IEnumerable<int> userIds, Action<IPagedList<Comment>> onSuccess, Action<ApiException> onError, UserMentionSort sortBy = UserMentionSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            MakeRequest<CommentResponse>("users", new string[] { userIds.Vectorize(), "mentioned" }, new
            {
                key = apiKey,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                page = page ?? null,
                pagesize = pageSize ?? null,
                min = min ?? null,
                max = max ?? null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection)
            }, (items) => onSuccess(new PagedList<Comment>(items.Comments, items)), onError);
        }

        public virtual void GetUserTimeline(int userId, Action<IPagedList<UserEvent>> onSuccess, Action<ApiException> onError, DateTime? fromDate = null, DateTime? toDate = null)
        {
            GetUserTimeline(new int[] { userId }, onSuccess, onError, fromDate, toDate);
        }

        public virtual void GetUserTimeline(IEnumerable<int> userIds, Action<IPagedList<UserEvent>> onSuccess, Action<ApiException> onError, DateTime? fromDate = null, DateTime? toDate = null)
        {
            MakeRequest<UserEventResponse>("users", new string[] { userIds.Vectorize(), "timeline" }, new
            {
                key = apiKey,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null
            }, (items) => onSuccess(new PagedList<UserEvent>(items.Events, items)), onError);
        }

        public virtual void GetUserReputation(int userId, Action<IPagedList<Reputation>> onSuccess, Action<ApiException> onError, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            GetUserReputation(new int[] { userId }, onSuccess, onError, page, pageSize, fromDate, toDate);
        }

        public virtual void GetUserReputation(IEnumerable<int> userIds, Action<IPagedList<Reputation>> onSuccess, Action<ApiException> onError, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            MakeRequest<ReputationResponse>("users", new string[] { userIds.Vectorize(), "reputation" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null
            }, (items) => onSuccess(new PagedList<Reputation>(items.Reputation, items)), onError);
        }

        public virtual void GetModerators(Action<IPagedList<User>> onSuccess, Action<ApiException> onError, int? page = null, int? pageSize = null, UserSort sortBy = UserSort.Reputation, SortDirection sortDirection = SortDirection.Descending, string filter = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            MakeRequest<UserResponse>("users", new string[] { "moderators" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                filter = filter,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null
            }, (response) => onSuccess(new PagedList<User>(response.Users, response)), onError);
        }

        public virtual void GetNoAnswerQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, int userId, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            GetNoAnswerQuestions(onSuccess, onError, userId.ToArray(), page, pageSize, sortBy, sortDirection, fromDate, toDate, min, max, includeBody, includeAnswers, includeComments);
        }

        public virtual void GetNoAnswerQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, IEnumerable<int> userIds, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            MakeRequest<QuestionResponse>("users", new string[] { userIds.Vectorize(), "questions", "no-answers" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                min = min ?? null,
                max = max ?? null,
                body = includeBody,
                comments = includeComments,
                answers = includeAnswers
            }, (response) => onSuccess(new PagedList<Question>(response.Questions, response)), onError);
        }

        /// <summary>
        /// Gets the questions asked by the users in userId which have at least one answer, but no accepted answer.
        /// Questions returned by this method have answers, but the owner has not opted to accept any of them.
        /// </summary>
        public virtual void GetUnacceptedQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, int userId, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            GetUnacceptedQuestions(onSuccess, onError, userId.ToArray(), page, pageSize, sortBy, sortDirection, fromDate, toDate, min, max, includeBody, includeAnswers, includeComments);
        }

        /// <summary>
        /// Gets the questions asked by the users in userIds which have at least one answer, but no accepted answer.
        /// Questions returned by this method have answers, but the owner has not opted to accept any of them.
        /// </summary>
        public virtual void GetUnacceptedQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, IEnumerable<int> userIds, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            MakeRequest<QuestionResponse>("users", new string[] { userIds.Vectorize(), "questions", "unaccepted" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                min = min ?? null,
                max = max ?? null,
                body = includeBody,
                comments = includeComments,
                answers = includeAnswers
            }, (response) => onSuccess(new PagedList<Question>(response.Questions, response)), onError);
        }

        /// <summary>
        /// Gets the questions asked by the users in id which the site consideres unanswered, while still having at least one answer posted.
        /// These rules are subject to change, but currently any question without at least one upvoted or accepted answer is considered unanswered.
        /// </summary>
        public virtual void GetUnansweredQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, int userId, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            GetUnansweredQuestions(onSuccess, onError, userId.ToArray(), page, pageSize, sortBy, sortDirection, fromDate, toDate, min, max, includeBody, includeAnswers, includeComments);
        }

        /// <summary>
        /// Gets the questions asked by the users in id which the site consideres unanswered, while still having at least one answer posted.
        /// These rules are subject to change, but currently any question without at least one upvoted or accepted answer is considered unanswered.
        /// </summary>
        public virtual void GetUnansweredQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, IEnumerable<int> userIds, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            MakeRequest<QuestionResponse>("users", new string[] { userIds.Vectorize(), "questions", "unanswered" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                min = min ?? null,
                max = max ?? null,
                body = includeBody,
                comments = includeComments,
                answers = includeAnswers
            }, (response) => onSuccess(new PagedList<Question>(response.Questions, response)), onError);
        }

        /// <summary>
        /// Returns the top 30 answer a user has posted in resposne to questions with the given tags.
        /// </summary>
        public virtual void GetTopTaggedAnswers(Action<IEnumerable<Answer>> onSuccess, Action<ApiException> onError, int userId, string tag, bool? includeBody = null, bool? includeComments = null)
        {
            GetTopTaggedAnswers(onSuccess, onError, userId, new string[] { tag }, includeBody, includeComments);
        }

        /// <summary>
        /// Returns the top 30 answer a user has posted in resposne to questions with the given tags.
        /// </summary>
        public virtual void GetTopTaggedAnswers(Action<IEnumerable<Answer>> onSuccess, Action<ApiException> onError, int userId, IEnumerable<string> tags, bool? includeBody = null, bool? includeComments = null)
        {
            if (tags == null)
                throw new ArgumentNullException("tags");

            MakeRequest<AnswerResponse>("users", new string[] { userId.ToString(), "tags", tags.Vectorize(), "top-answers" }, new
            {
                key = apiKey,
                body = includeBody,
                comments = includeComments
            }, (response) => onSuccess(new PagedList<Answer>(response.Answers, response)), onError);
        }

        /// <summary>
        /// Returns the top 30 answer a user has posted in resposne to questions with the given tags.
        /// </summary>
        public virtual void GetTopTaggedQuestions(Action<IEnumerable<Question>> onSuccess, Action<ApiException> onError, int userId, string tag, bool? includeBody = null, bool? includeComments = null, bool? includeAnswers = null)
        {
            GetTopTaggedQuestions(onSuccess, onError, userId, new string[] { tag }, includeBody, includeComments, includeAnswers);
        }

        /// <summary>
        /// Returns the top 30 answer a user has posted in resposne to questions with the given tags.
        /// </summary>
        public virtual void GetTopTaggedQuestions(Action<IEnumerable<Question>> onSuccess, Action<ApiException> onError, int userId, IEnumerable<string> tags, bool? includeBody = null, bool? includeComments = null, bool? includeAnswers = null)
        {
            if (tags == null)
                throw new ArgumentNullException("tags");

            MakeRequest<QuestionResponse>("users", new string[] { userId.ToString(), "tags", tags.Vectorize(), "top-questions" }, new
            {
                key = apiKey,
                body = includeBody,
                comments = includeComments,
                answers = includeAnswers
            }, (response) => onSuccess(new PagedList<Question>(response.Questions, response)), onError);
        }

        /// <summary>
        /// Returns a single user's top 30 tags by answer score.
        /// </summary>
        public virtual void GetTopAnswerTags(Action<IEnumerable<TopTag>> onSuccess, Action<ApiException> onError, int userId)
        {
            MakeRequest<TopTagResponse>("users", new string[] { userId.ToString(), "top-answer-tags" }, new
            {
                key = apiKey,
                id = userId
            }, (response) => onSuccess(response.TopTags), onError);
        }

        /// <summary>
        /// Returns a single user's top 30 tags by question score.
        /// </summary>
        public virtual void GetTopQuestionTags(Action<IEnumerable<TopTag>> onSuccess, Action<ApiException> onError, int userId)
        {
            MakeRequest<TopTagResponse>("users", new string[] { userId.ToString(), "top-question-tags" }, new
            {
                key = apiKey,
                id = userId
            }, (response) => onSuccess(response.TopTags), onError);
        }
    }
}