﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCSoft.WX.Framework.Models.ApiRequests;
using JCSoft.WX.Framework.Models.ApiResponses;
using Xunit;

namespace FrameworkCoreTest.Api
{
    public class GetCurrentAutoreplyInfoTest : MockPostApiBaseTest<GetCurrentAutoreplyInfoRequest, GetCurrentAutoreplyInfoResponse>
    {

        [Fact]
        public void MockCurrentAutoreplyInfoTest()
        {
            MockSetup(false);
            var response = mock_client.Object.Execute(Request);
            Assert.IsType<GetCurrentAutoreplyInfoResponse>(response);
            
        }

        protected override GetCurrentAutoreplyInfoRequest InitRequestObject()
        {
            return new GetCurrentAutoreplyInfoRequest
            {
                AccessToken = "123"
            };
        }

        protected override string GetReturnResult(bool errResult)
        {
            if (errResult) return s_errmsg;
            return @"{ 
                       ""is_add_friend_reply_open"": 1, 
                       ""is_autoreply_open"": 1, 
                       ""add_friend_autoreply_info"": { 
                           ""type"": ""text"", 
                           ""content"": ""Thanks for your attention!""
                       }, 
                       ""message_default_autoreply_info"": { 
                           ""type"": ""text"", 
                           ""content"": ""Hello, this is autoreply!""
                       }, 
                       ""keyword_autoreply_info"": { 
                           ""list"": [ 
                               { 
                                   ""rule_name"": ""autoreply-news"", 
                                   ""create_time"": 1423028166, 
                                   ""reply_mode"": ""reply_all"", 
                                   ""keyword_list_info"": [ 
                                       { 
                                           ""type"": ""text"", 
                                           ""match_mode"": ""contain"", 
                                           ""content"": ""news测试""//此处content即为关键词内容
                                       }
                                   ], 
                                   ""reply_list_info"": [ 
                                       { 
                                           ""type"": ""news"", 
                                           ""news_info"": { 
                                               ""list"": [ 
                                                   { 
                                                       ""title"": ""it's news"", 
                                                       ""author"": ""jim"", 
                                                       ""digest"": ""it's digest"", 
                                                       ""show_cover"": 1, 
                                                       ""cover_url"": ""http://mmbiz.qpic.cn/mmbiz/GE7et87vE9vicuCibqXsX9GPPLuEtBfXfKbE8sWdt2DDcL0dMfQWJWTVn1N8DxI0gcRmrtqBOuwQHeuPKmFLK0ZQ/0"", 
                                                       ""content_url"": ""http://mp.weixin.qq.com/s?__biz=MjM5ODUwNTM3Ng==&mid=203929886&idx=1&sn=628f964cf0c6d84c026881b6959aea8b#rd"", 
                                                       ""source_url"": ""http://www.url.com""
                                                   }
                                               ]
                                           }
                                       }, 
                                       { 
                                           ""type"": ""news"", 
                                           ""news_info"": { 
                                               ""list"": [ 
                                                   { 
                                                       ""title"": ""MULTI_NEWS"", 
                                                       ""author"": ""JIMZHENG"", 
                                                       ""digest"": ""text"", 
                                                       ""show_cover"": 0, 
                                                       ""cover_url"": ""http://mmbiz.qpic.cn/mmbiz/GE7et87vE9vicuCibqXsX9GPPLuEtBfXfK0HKuBIa1A1cypS0uY1wickv70iaY1gf3I1DTszuJoS3lAVLvhTcm9sDA/0"", 
                                                       ""content_url"": ""http://mp.weixin.qq.com/s?__biz=MjM5ODUwNTM3Ng==&mid=204013432&idx=1&sn=80ce6d9abcb832237bf86c87e50fda15#rd"", 
                                                       ""source_url"": """"
                                                   },
                                                   { 
                                                       ""title"": ""MULTI_NEWS4"", 
                                                       ""author"": ""JIMZHENG"", 
                                                       ""digest"": ""MULTI_NEWSMULTI_NEWSMULTI_NEWSMULTI_NEWSMULTI_NEWSMULT"", 
                                                       ""show_cover"": 1, 
                                                       ""cover_url"": ""http://mmbiz.qpic.cn/mmbiz/GE7et87vE9vicuCibqXsX9GPPLuEtBfXfKbE8sWdt2DDcL0dMfQWJWTVn1N8DxI0gcRmrtqBOuwQHeuPKmFLK0ZQ/0"", 
                                                       ""content_url"": ""http://mp.weixin.qq.com/s?__biz=MjM5ODUwNTM3Ng==&mid=204013432&idx=5&sn=b4ef73a915e7c2265e437096582774af#rd"", 
                                                       ""source_url"": """"
                                                   }
                                               ]
                                           }
                                       }
                                   ]
                               }, 
                               { 
                                   ""rule_name"": ""autoreply-voice"", 
                                   ""create_time"": 1423027971, 
                                   ""reply_mode"": ""random_one"", 
                                   ""keyword_list_info"": [ 
                                       { 
                                           ""type"": ""text"", 
                                           ""match_mode"": ""contain"", 
                                           ""content"": ""voice测试""
                                       }
                                   ], 
                                   ""reply_list_info"": [ 
                                       { 
                                           ""type"": ""voice"", 
                                           ""content"": ""NESsxgHEvAcg3egJTtYj4uG1PTL6iPhratdWKDLAXYErhN6oEEfMdVyblWtBY5vp""
                                       }
                                   ]
                               }, 
                               { 
                                   ""rule_name"": ""autoreply-text"", 
                                   ""create_time"": 1423027926, 
                                   ""reply_mode"": ""random_one"", 
                                   ""keyword_list_info"": [ 
                                       { 
                                           ""type"": ""text"", 
                                           ""match_mode"": ""contain"", 
                                           ""content"": ""text测试""
                                       }
                                   ], 
                                   ""reply_list_info"": [ 
                                       { 
                                           ""type"": ""text"", 
                                           ""content"": ""hello!text!""
                                       }
                                   ]
                               }, 
                               { 
                                   ""rule_name"": ""autoreply-video"", 
                                   ""create_time"": 1423027801, 
                                   ""reply_mode"": ""random_one"", 
                                   ""keyword_list_info"": [ 
                                       { 
                                           ""type"": ""text"", 
                                           ""match_mode"": ""equal"", 
                                           ""content"": ""video测试""
                                       }
                                   ], 
                                   ""reply_list_info"": [ 
                                       { 
                                           ""type"": ""video"", 
                                           ""content"": ""http://61.182.133.153/vweixinp.tc.qq.com/1007_114bcede9a2244eeb5ab7f76d951df5f.f10.mp4?vkey=7183E5C952B16C3AB1991BA8138673DE1037CB82A29801A504B64A77F691BF9DF7AD054A9B7FE683&sha=0&save=1""
                                       }
                                   ]
                               }
                           ]
                       }
                    }";
        }
    }
}
