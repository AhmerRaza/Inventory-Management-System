﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace IMS.DAL
{
    class MyInitializer : CreateDatabaseIfNotExists<IMS_DB>
    {
        protected override void Seed(IMS_DB context)
        {

        }
    }
}
