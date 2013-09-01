﻿using FubuDocs.Topics;
using FubuMVC.Core.Http;
using HtmlTags;

namespace FubuDocs.Navigation
{
    public class NamedTopicLinkTag : HtmlTag
    {
        public NamedTopicLinkTag(Topic node, ICurrentHttpRequest currentRequest)
            : base("li")
        {
            Add("a").Attr("href", currentRequest.ToRelativeUrl(node.AbsoluteUrl)).Attr("data-key", node.Name).Text(node.Title + " »");
        }
    }
}