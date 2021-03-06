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
    public partial class Testimonial
    {
        public const string Codename = "testimonial";
        public const string CompanyCodename = "company";
        public const string QuoteCodename = "quote";
        public const string QuotedSourceCodename = "quoted_source";
        public const string TitleCodename = "title";

        public string Company { get; set; }
        public IRichTextContent Quote { get; set; }
        public string QuotedSource { get; set; }
        public ContentItemSystemAttributes System { get; set; }
        public string Title { get; set; }
    }
}