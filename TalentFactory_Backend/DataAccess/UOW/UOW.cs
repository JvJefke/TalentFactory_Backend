using TalentFactory_Backend.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_Backend.DataAccess.UOW
{
    public class UOW : TalentFactory_Backend.DataAccess.UOW.IUOW
    {
        private TFContext context = null;

        public UOW(TFContext context)
        {
            this.context = context;
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}