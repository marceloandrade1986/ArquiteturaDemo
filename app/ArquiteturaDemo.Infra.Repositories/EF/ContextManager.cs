﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class ContextManager
    {
        private const string ContextKey = "ContextManager.Context";
        public DbContext Context 
        {
            get
            {
                if (HttpContext.Current.Items[ContextKey] == null) {
                    HttpContext.Current.Items[ContextKey] = new ArquiteturaContext();
                }

                return (ArquiteturaContext)HttpContext.Current.Items[ContextKey];
            }
        }
    }
}
