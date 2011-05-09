using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacky
{
    public partial class StackyClient
    {
        public virtual IPagedList<User> GetUsers(UserSort sortBy = UserSort.Reputation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, string filter = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            var response = MakeRequest<UserResponse>("users", null, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                filter = filter,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                min = min ?? null,
                max = max ?? null
            });
            return new PagedList<User>(response.Users, response);
        }

        public virtual IPagedList<User> GetUsers(IEnumerable<int> userIds, UserSort sortBy = UserSort.Reputation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, string filter = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
           var response = MakeRequest<UserResponse>("users", new string[] { userIds.Vectorize() }, new
           {
               key = apiKey,
               page = page ?? null,
               pagesize = pageSize ?? null,
               filter = filter,
               sort = sortBy.ToString().ToLower(),
               order = GetSortDirection(sortDirection),
               fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
               todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
               min = min ?? null,
               max = max ?? null
           });
           return new PagedList<User>(response.Users, response);
        }

        public virtual User GetUser(int userId)
        {
            return GetUsers(userId.ToArray()).FirstOrDefault();
        }

        public virtual IPagedList<Comment> GetUserMentions(int userId, UserMentionSort sortBy = UserMentionSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            return GetUserMentions(userId.ToArray(), sortBy, sortDirection, page, pageSize, fromDate, toDate, min, max);
        }

        public virtual IPagedList<Comment> GetUserMentions(IEnumerable<int> userIds, UserMentionSort sortBy = UserMentionSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            var response = MakeRequest<CommentResponse>("users", new string[] { userIds.Vectorize(), "mentioned" }, new
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
            });
            return new PagedList<Comment>(response.Comments, response);
        }

        public virtual IPagedList<UserEvent> GetUserTimeline(int userId, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            return GetUserTimeline(userId.ToArray(), page, pageSize, fromDate, toDate);
        }

        public virtual IPagedList<UserEvent> GetUserTimeline(IEnumerable<int> userIds, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var response = MakeRequest<UserEventResponse>("users", new string[] { userIds.Vectorize(), "timeline" }, new
            {
                key = apiKey,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                page = page ?? null,
                pagesize = pageSize ?? null
            });
            return new PagedList<UserEvent>(response.Events, response);
        }

        public virtual IPagedList<Reputation> GetUserReputation(int userId, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            return GetUserReputation(userId.ToArray(), page, pageSize, fromDate, toDate);
        }

        public virtual IPagedList<Reputation> GetUserReputation(IEnumerable<int> userIds, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var response = MakeRequest<ReputationResponse>("users", new string[] { userIds.Vectorize(), "reputation" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null
            });
            return new PagedList<Reputation>(response.Reputation, response);
        }

        public virtual IPagedList<User> GetModerators(int? page = null, int? pageSize = null, UserSort sortBy = UserSort.Reputation, SortDirection sortDirection = SortDirection.Descending, string filter = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var response = MakeRequest<UserResponse>("users", new string[] { "moderators" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                filter = filter,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null
            });
            return new PagedList<User>(response.Users, response);
        }

        /// <summary>
        /// Gets the questions asked by the users in userId which have no answers.
        /// Questions returns by this method actually have zero undeleted answers.
        /// </summary>
        public virtual IPagedList<Question> GetNoAnswerQuestions(int userId, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            return GetNoAnswerQuestions(userId.ToArray(), page, pageSize, sortBy, sortDirection, fromDate, toDate, min, max, includeBody, includeAnswers, includeComments);
        }

        /// <summary>
        /// Gets the questions asked by the users in userIds which have no answers.
        /// Questions returns by this method actually have zero undeleted answers.
        /// </summary>
        public virtual IPagedList<Question> GetNoAnswerQuestions(IEnumerable<int> userIds, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            var response = MakeRequest<QuestionResponse>("users", new string[] { userIds.Vectorize(), "questions", "no-answers" }, new
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
            });
            return new PagedList<Question>(response.Questions, response);
        }

        /// <summary>
        /// Gets the questions asked by the users in userId which have at least one answer, but no accepted answer.
        /// Questions returned by this method have answers, but the owner has not opted to accept any of them.
        /// </summary>
        public virtual IPagedList<Question> GetUnacceptedQuestions(int userId, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            return GetUnacceptedQuestions(userId.ToArray(), page, pageSize, sortBy, sortDirection, fromDate, toDate, min, max, includeBody, includeAnswers, includeComments);
        }

        /// <summary>
        /// Gets the questions asked by the users in userIds which have at least one answer, but no accepted answer.
        /// Questions returned by this method have answers, but the owner has not opted to accept any of them.
        /// </summary>
        public virtual IPagedList<Question> GetUnacceptedQuestions(IEnumerable<int> userIds, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            var response = MakeRequest<QuestionResponse>("users", new string[] { userIds.Vectorize(), "questions", "unaccepted" }, new
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
            });
            return new PagedList<Question>(response.Questions, response);
        }

        public virtual IPagedList<Question> GetUnansweredQuestions(int userId, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            return GetUnansweredQuestions(userId.ToArray(), page, pageSize, sortBy, sortDirection, fromDate, toDate, min, max, includeBody, includeAnswers, includeComments);
        }

        public virtual IPagedList<Question> GetUnansweredQuestions(IEnumerable<int> userIds, int? page = null, int? pageSize = null, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, bool? includeBody = null, bool? includeAnswers = null, bool? includeComments = null)
        {
            var response = MakeRequest<QuestionResponse>("users", new string[] { userIds.Vectorize(), "questions", "unanswered" }, new
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
            });
            return new PagedList<Question>(response.Questions, response);
        }

        /// <summary>
        /// Returns the top 30 answer a user has posted in resposne to questions with the given tags.
        /// </summary>
        public virtual IEnumerable<Answer> GetTopTaggedAnswers(int userId, string tag, bool? includeBody = null, bool? includeComments = null)
        {
            return GetTopTaggedAnswers(userId, new string[] { tag }, includeBody, includeComments);
        }

        /// <summary>
        /// Returns the top 30 answer a user has posted in resposne to questions with the given tags.
        /// </summary>
        public virtual IEnumerable<Answer> GetTopTaggedAnswers(int userId, IEnumerable<string> tags, bool? includeBody = null, bool? includeComments = null)
        {
            if (tags == null)
                throw new ArgumentNullException("tags");

            var response = MakeRequest<AnswerResponse>("users", new string[] { userId.ToString(), "tags", tags.Vectorize(), "top-answers" }, new
            {
                key = apiKey,
                body = includeBody,
                comments = includeComments
            });
            return response.Answers;
        }

        /// <summary>
        /// Returns the top 30 questions a user has asked with the given tags.
        /// </summary>
        public virtual IEnumerable<Question> GetTopTaggedQuestions(int userId, string tag, bool? includeBody = null, bool? includeComments = null, bool? includeAnswers = null)
        {
            return GetTopTaggedQuestions(userId, new string[] { tag }, includeBody, includeComments, includeAnswers);
        }

        /// <summary>
        /// Returns the top 30 questions a user has asked with the given tags.
        /// </summary>
        public virtual IEnumerable<Question> GetTopTaggedQuestions(int userId, IEnumerable<string> tags, bool? includeBody = null, bool? includeComments = null, bool? includeAnswers = null)
        {
            if (tags == null)
                throw new ArgumentNullException("tags");

            var response = MakeRequest<QuestionResponse>("users", new string[] { userId.ToString(), "tags", tags.Vectorize(), "top-questions" }, new
            {
                key = apiKey,
                body = includeBody,
                comments = includeComments,
                answers = includeAnswers
            });
            return response.Questions;
        }

        /// <summary>
        /// Returns a single user's top 30 tags by answer score.
        /// </summary>
        public virtual IEnumerable<TopTag> GetTopAnswerTags(int userId)
        {
            var response = MakeRequest<TopTagResponse>("users", new string[] { userId.ToString(), "top-answer-tags" }, new
            {
                key = apiKey,
                id = userId
            });
            return response.TopTags;
        }

        /// <summary>
        /// Returns a single user's top 30 tags by question score.
        /// </summary>
        public virtual IEnumerable<TopTag> GetTopQuestionTags(int userId)
        {
            var response = MakeRequest<TopTagResponse>("users", new string[] { userId.ToString(), "top-question-tags" }, new
            {
                key = apiKey,
                id = userId
            });
            return response.TopTags;
        }
    }
}