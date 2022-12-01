using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace KomunYslugi.Data
{
    public class Project
    {
        [BsonId]
        public ObjectId _id;

        public string Name { get; set; }
        public string Department { get; set; }

        public User designer { get; set; }
        public User developer { get; set; }
        public User customer { get; set; }

        //Застройщик
        //Водоснобжение
        [BsonIgnoreIfNull]
        public List<DeveloperData> DeveloperDataWater = new List<DeveloperData>()
        {
            new DeveloperData("1. Акт обследования и выбора трассы сети водоснабжения"),
            new DeveloperData("2. Акт обследования и выбор места под проектируемую скважину"),
            new DeveloperData("3. Согласованный ситуационный план (М1:10000 или М1:25000)" +
                " с нанесением источников воды (скважин,родников и т.п.), существующих" +
                " водонапорных башен, предполагаемой трассой водопровода и места врезки " +
                "в существующую сеть."),
            new DeveloperData("4. План населённого пункта в М 1:1000 или М 1:500 топографическая" +
                " съемка)."),
            new DeveloperData("5. технические условия на водоснабжение"),
            new DeveloperData("6. Технические условия на электроснабжение (для насосной станции" +
                " первого или второго подъема);"),
            new DeveloperData("7. Градостроительный план земельного участка"),
            new DeveloperData("8. Справка согласования с собственниками земельных участков"),
            new DeveloperData("9. документ, подтверждающий проведение межевания с присвоением" +
                " кадастрового номера земельного участка под строительство водопровода и " +
                "сооружений на нем."),
            new DeveloperData("10. заключение Органа Роспотребнадзора" +
                "санитарно-эпидемиологической службы по отводу" +
                "земельного участка и результат радиационного" +
                "обследования."),
            new DeveloperData("11. Сведения о наличие водозаборных скважин (родников)" +
                "на территории хозяйства.")
        };
        //Газификация
        [BsonIgnoreIfNull]
        public List<DeveloperData> DeveloperDataGas = new List<DeveloperData>()
        {
            new DeveloperData("Письмо-обращение на имя Президента," +
                "Премьер-Министра, Минстрой РТ"),
            new DeveloperData("Задание на проектирование "),
            new DeveloperData("Ситуационный план (утвержденный" +
                "исполкомом)"),
            new DeveloperData("Технические условия на присоединение к" +
                "газораспределительной сети (№, дата," +
                "срок действий Технических условий)"),
            new DeveloperData("Технический паспорт (план БТИ) объекта" +
                "СКБ"),
            new DeveloperData("Технический паспорт (план БТИ)" +
                "существующей котельной"),
            new DeveloperData("АКТ обследования объекта "),
            new DeveloperData("Технические условия на сети" +
                "электроснабжение, водоснабжения,водоотведения при установке БМК"),
            new DeveloperData("Согласование посадки котельной ")
        };
        //Проектировщик
        //Водоснобжение
        [BsonIgnoreIfNull]
        public List<DesignerData> DesignerDataWater = new List<DesignerData>()
        {
            new DesignerData("Диаметр (мм) трубопровода и протяженность" +
                "линейного объекта (м)", ""),
            new DesignerData("Производительность БОС, м3" +
                "/сут", ""),
            new DesignerData("кол.-во (шт) и производительность КНС (м3" +
                "/ч) ", ""),
            new DesignerData("Сметная стоимость работ, тыс. руб. ", ""),
            new DesignerData("Срок разработки проектной документации, месяцев", "")
        };
        //Газификация
        [BsonIgnoreIfNull]
        public List<DesignerData> DesignerDataGas = new List<DesignerData>()
        {
            new DesignerData("Диаметр (мм) трубопровода и протяженность" +
                "линейного объекта (м)", ""),
            new DesignerData("Диаметр (мм) трубопровода и протяженность" +
                "линейного объекта (м)", ""),
            new DesignerData("Сметная стоимость работ, тыс. руб. ", ""),
            new DesignerData("Срок разработки проектной документации," +
                "месяцев", "")
        };

        public Project(string department, User designer, User developer, User customer, string name)
        {
            Department = department;
            this.designer = designer;
            this.developer = developer;
            this.customer = customer;
            Name = name;
        }
    }
}
