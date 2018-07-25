using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CategoryServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICategoryService" in both code and config file together.
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<Category> GetAllCategories();

        [OperationContract]
        void InsertCategory(Category category);

        [OperationContract]
        int DeleteCategory(Category category);

        [OperationContract]
        int UpdateCateogry(Category original_Category, Category category);
    }

    [DataContract]
    public class Category
    {
        [DataMember]
        public string CategoryID { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
    }
}
