﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Dynamic;
using System.Web.Mvc;

public static class cExpando
{
    public static ExpandoObject ToExpando(this object anonymousObject)
    {
        IDictionary<string, object> anonymousDictionary = HtmlHelper.AnonymousObjectToHtmlAttributes(anonymousObject);
        IDictionary<string, object> expando = new ExpandoObject();

        foreach (var item in anonymousDictionary)
            expando.Add(item);

        return (ExpandoObject)expando;
    }
}