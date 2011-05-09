using Newtonsoft.Json;

namespace Stacky
{
    public class TopTag : Entity
    {
        private string tagName;
        private int questionScore;
        private int questionCount;
        private int answerScore;
        private int answerCount;

        [JsonProperty("tag_name")]
        public string TagName
        {
            get { return tagName; }
            set { tagName = value; NotifyOfPropertyChange(() => TagName); }
        }

        [JsonProperty("question_score")]
        public int QuestionScore
        {
            get { return questionScore; }
            set { questionScore = value; NotifyOfPropertyChange(() => QuestionScore); }
        }

        [JsonProperty("question_count")]
        public int QuestionCount
        {
            get { return questionCount; }
            set { questionCount = value; NotifyOfPropertyChange(() => QuestionCount); }
        }

        [JsonProperty("answer_score")]
        public int AnswerScore
        {
            get { return answerScore; }
            set { answerScore = value; NotifyOfPropertyChange(() => AnswerScore); }
        }

        [JsonProperty("answer_count")]
        public int AnswerCount
        {
            get { return answerCount; }
            set { answerCount = value; NotifyOfPropertyChange(() => AnswerCount); }
        }
    }
}