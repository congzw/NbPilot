using FluentNHibernate.Mapping;

namespace NbCloud.BaseLib.Categories._Maps
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table("Lib_Categories_Category");
            Id(x => x.Id).GeneratedBy.GuidComb();
            Map(x => x.RelationCode).Not.Nullable().Index("Index_Lib_Categories_Category_RelationCode");
            Map(x => x.Name).Index("Index_Lib_Categories_Category_Name");
            Map(x => x.SortNum).Index("Index_Lib_Categories_Category_SortNum");
            Map(x => x.Tags).Index("Index_Lib_Categories_Category_Tags");
            Map(x => x.CreateDate);

            References(x => x.Parent)
                .Column("ParentId")
                .ForeignKey("FK_Categories_Category_Parent");

            //References<Category>(x => x.ParentId).Column("ParentId").ForeignKey("FK_Categories_Category_Parent");
        }
    }
}
