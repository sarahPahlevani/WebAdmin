using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAdmin.Models
{
    public static class UserGroups
    {
        public const string Administrator = nameof(Administrator);
        public const string RealEstateAdministrator = nameof(RealEstateAdministrator);
        public const string Agent = nameof(Agent);
        public const string MarketAssistance = nameof(MarketAssistance);
        public const string MarketAssistancePlus = nameof(MarketAssistancePlus);
        public const string PropertyOwner = nameof(PropertyOwner);
        public const string AppClient = nameof(AppClient);
    }

}
