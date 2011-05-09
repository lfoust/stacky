using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stacky.IntegrationTests
{
    [TestClass]
    public class TagTests : IntegrationTest
    {
        [TestMethod]
        public void Tag_GetTags()
        {
            var tags = Client.GetTags();
            Assert.IsNotNull(tags);
        }

        [TestMethod]
        public void Tag_GetTags_ContainsPagingInformation()
        {
            var tags = Client.GetTags();
            Assert.IsNotNull(tags);
            Assert.IsTrue(tags.PageSize > 0);
            Assert.IsTrue(tags.CurrentPage > 0);
            Assert.IsTrue(tags.TotalItems > 0);
        }

        [TestMethod]
        public void Tag_GetTags_Async()
        {
            ClientAsync.GetTags(tags => Assert.IsNotNull(tags), error => Assert.Fail());
        }

        [TestMethod]
        public void Tag_GetTagsByUser()
        {
            var tags = Client.GetTagsByUser(1464);
            Assert.IsNotNull(tags);
        }

        [TestMethod]
        public void Tag_GetTagsByUser_Async()
        {
            ClientAsync.GetTagsByUser(1464, tags => Assert.IsNotNull(tags), error => Assert.Fail());
        }

        [TestMethod]
        public void Tag_GetAllTagSynonyms()
        {
            var synonyms = Client.GetAllTagSynonyms();
            Assert.IsNotNull(synonyms);
            Assert.IsTrue(synonyms.TotalItems > 0);
        }

        [TestMethod]
        public void Tag_GetTagSynonyms()
        {
            var synonyms = Client.GetTagSynonyms("java");
            Assert.IsNotNull(synonyms);
        }

        [TestMethod]
        public void Tag_GetTagWikis()
        {
            var wikis = Client.GetTagWikis("java");
            Assert.IsNotNull(wikis);
            foreach (var wiki in wikis)
            {
                Assert.IsNotNull(wiki.LastBodyEditor);
                Assert.IsNotNull(wiki.LastExcerptEditor);
            }
        }

        [TestMethod]
        public void Tag_GetTopAskers()
        {
            var topUsers = Client.GetTopAskers("java", TopUserPeriod.AllTime);
            Assert.IsNotNull(topUsers);
            Assert.IsTrue(topUsers.Count() > 0);
        }

        [TestMethod]
        public void Tag_GetTopAnsweres()
        {
            var topUsers = Client.GetTopAnswerers("java", TopUserPeriod.AllTime);
            Assert.IsNotNull(topUsers);
            Assert.IsTrue(topUsers.Count() > 0);
        }
    }
}