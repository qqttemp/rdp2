using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Card.Models
{
    public class CardTokens
    {
        /// <summary>
        /// 返回的卡片总数
        /// </summary>
        public int Count { get; set; }

        public TokenCard[] TokenCards { get; set; }
    }

    public class TokenCard
    {
        public string Id { get; set; }
        public Token[] Tokens { get; set; }
    }

    public class Token
    {
        public string Id { get; set; }
        public TokenLink[] Links { get; set; }
    }

    public class TokenLink
    {
        public string Href { get; set; }
        public string Rel { get; set; }
    }
}
