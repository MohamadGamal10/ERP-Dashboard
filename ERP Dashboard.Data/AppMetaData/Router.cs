namespace ERP_Dashboard.Data.AppMetaData
{
    public static class Router
    {
        public const string root = "Api";
        public const string version = "V1";
        public const string rule = root + "/" + version + "/";

        public static class CustomerRouting
        {
            public const string perfix = rule + "Customer";
            public const string getAll = perfix + "/GetAll";
            public const string getById = perfix + "/GetById/{id}";
            public const string create = perfix + "/Create";
            public const string edit = perfix + "/Edit";
            public const string delete = perfix + "/Delete/{id}";
        }
        public static class CategoryRouting
        {
            public const string perfix = rule + "Category";
            public const string getAll = perfix + "/GetAll";
            public const string getById = perfix + "/GetById/{id}";
            public const string create = perfix + "/Create";
            public const string edit = perfix + "/Edit";
            public const string delete = perfix + "/Delete/{id}";
        }
        public static class SupplierRouting
        {
            public const string perfix = rule + "Supplier";
            public const string getAll = perfix + "/GetAll";
            public const string getById = perfix + "/GetById/{id}";
            public const string create = perfix + "/Create";
            public const string edit = perfix + "/Edit";
            public const string delete = perfix + "/Delete/{id}";
        }
    }
}
