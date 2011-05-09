using Newtonsoft.Json;

namespace Stacky
{
    public class TopUser : Entity
    {
        private UserInfo user;
        private int score;
        private int postCount;

        [JsonProperty("user")]
        public UserInfo User
        {
            get { return user; }
            set { user = value; NotifyOfPropertyChange(() => User); }
        }

        [JsonProperty("score")]
        public int Score
        {
            get { return score; }
            set { score = value; NotifyOfPropertyChange(() => Score); }
        }

        [JsonProperty("post_count")]
        public int PostCount
        {
            get { return postCount; }
            set { postCount = value; NotifyOfPropertyChange(() => PostCount); }
        }
    }
}