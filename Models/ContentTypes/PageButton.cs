// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;

namespace mecp_kontent_core.Models
{
    public partial class PageButton
    {
        public const string Codename = "page_button";
        public const string ButtonTextCodename = "button_text";
        public const string ExternalPageLinkCodename = "external_page_link";
        public const string InternalPageLinkCodename = "internal_page_link";
        public const string OpenInNewTabCodename = "open_in_new_tab";

        public string ButtonText { get; set; }
        public string ExternalPageLink { get; set; }
        public IEnumerable<object> InternalPageLink { get; set; }
        public IEnumerable<MultipleChoiceOption> OpenInNewTab { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}