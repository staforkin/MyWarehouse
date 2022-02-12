namespace MyWarehouse.Infrastructure.Authorization.Constants
{
    public static class KnownClaims
    {
        public static class ExampleClaim
        {
            public static string Name => nameof(ExampleClaim);

            public static class Values
            {
                public static string ExampleValue1 => nameof(ExampleValue1);
                public static string ExampleValue2 => nameof(ExampleValue2);
            }
        }

        public static class PermissionClaim
        {
            public static string Name => nameof(PermissionClaim);

            public static class Values
            {
                public static string EditPartners => nameof(EditPartners);
                public static string EditProducts => nameof(EditProducts);
                public static string EditPrices => nameof(EditPrices);
                public static string EditUsers => nameof(EditUsers);
            }
        }

        public static class AdministartorClaim
        {
            public static string Name => nameof(AdministartorClaim);

            public static class Values
            {
                public static string Administrator = nameof(Administrator);
            }
        }
    }
}
