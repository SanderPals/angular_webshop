﻿using System;
using System.Collections.Generic;

namespace Site.Data
{
    public partial class PageTemplateFields
    {
        public int Id { get; set; }
        public int PageTemplateId { get; set; }
        public string CallName { get; set; }
        public string Heading { get; set; }
        public string Type { get; set; }
        public int CustomOrder { get; set; }
        public string DefaultValue { get; set; }

        public PageTemplates PageTemplate { get; set; }
    }
}
